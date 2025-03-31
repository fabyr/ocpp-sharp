using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using OcppSharp.Protocol;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;

namespace OcppSharp.Client;

public class OcppSharpClient : IDisposable
{
    private readonly ILogger<OcppSharpClient> _logger;
    private readonly ILoggerFactory _loggerFactory;

    /// <summary>
    /// The number of bytes that will be accepted in a single WebSocket message.
    /// <para>If it is set to null, the default of 32767 will be used.</para>
    /// </summary>
    public int? MaxIncomingData { get; set; } = null;

    protected virtual int MaxIncomingDataValue => MaxIncomingData ?? 32767;

    public WebSocket? Socket { get; protected set; }

    public ProtocolVersion OcppVersion { get; }

    protected bool _stopLoop = false;

    /// <summary>
    /// The encoding used for encoding and decoding WebSocket data.
    /// <para>Defaults to <see cref="Encoding.UTF8"/></para>
    /// </summary>
    public static Encoding Encoding { get; set; } = Encoding.UTF8;

    public ICredentials? Credentials { get; }

    /// <summary>
    /// The ID the station identifies with.
    /// </summary>
    public string Id { get; }

    public DateTime? LastCommunication { get; set; }

    public bool Disposed { get; protected set; } = false;

    protected delegate void ResponseHandlerDelegateInternal(OcppSharpClient client, Response response);

    public event ResponseHandlerDelegate? ResponseReceived;

    public event ResponseHandlerDelegate? ResponseSent;

    protected event ResponseHandlerDelegateInternal? ResponseReceivedInternal;

    public event RequestHandlerDelegate? RequestReceived;

    public event RequestHandlerDelegate? RequestSent;

    public event EventHandler? Closed;

    protected readonly List<ClientRequestHandler> handlers = [];

    /// <summary>
    /// Create an OCPP-Client using an existing <see cref="WebSocket"/> connection.
    /// This is realistically only needed by a server which is accepting new clients via its websocket logic.
    /// </summary>
    /// <param name="socket">The client websocket connection.</param>
    /// <param name="id">The id the client identifies with.</param>
    /// <param name="version">The ocpp protocol version to use.</param>
    /// <param name="loggerFactory">Optional logger factory.</param>
    public OcppSharpClient(WebSocket socket, string id, ProtocolVersion version, ILoggerFactory? loggerFactory = null)
    {
        Socket = socket;
        OcppVersion = version;
        Id = id;

        _loggerFactory = loggerFactory ?? NullLoggerFactory.Instance;
        _logger = _loggerFactory.CreateLogger<OcppSharpClient>();
    }

    /// <summary>
    /// Create an OCPP-Client.
    /// </summary>
    /// <param name="id">
    /// The id the client identifies with.
    /// This should ideally be the same that is used in the url when calling <see cref="Connect"/> afterwards.
    /// </param>
    /// <param name="version">The ocpp protocol version to use.</param>
    /// <param name="loggerFactory">Optional logger factory.</param>
    public OcppSharpClient(string id, ProtocolVersion version, ILoggerFactory? loggerFactory = null)
    {
        OcppVersion = version;
        Id = id;

        _loggerFactory = loggerFactory ?? NullLoggerFactory.Instance;
        _logger = _loggerFactory.CreateLogger<OcppSharpClient>();
    }

    protected static InvalidOperationException UninitializedException => new("This client has not been initialized yet.");

    /// <summary>
    /// Starts the asynchronous loop.
    /// </summary>
    /// <remarks>
    /// This method should only be used if the client has been initialized
    /// using an existing WebSocket using this constructor: <see cref="OcppSharpClient(WebSocket, string, ProtocolVersion, ILoggerFactory?)"/>.
    /// <para>Use <see cref="Connect"/> in the other case instead.</para>
    /// </remarks>
    /// <exception cref="ObjectDisposedException">If this client is already disposed.</exception>
    /// <exception cref="InvalidOperationException">If this client has not yet been initialized with a connection.</exception>
    public virtual async void StartLoop()
    {
        ObjectDisposedException.ThrowIf(Disposed, this);

        if (Socket == null)
            throw UninitializedException;

        _logger.LogDebug("Client loop start.");
        _stopLoop = false;
        byte[]? receiveBuffer = null;
        try
        {
            while (!_stopLoop && Socket.State == WebSocketState.Open)
            {
                // update the size of the buffer if MaxIncomingDataValue changes
                if (receiveBuffer?.Length != MaxIncomingDataValue)
                    receiveBuffer = new byte[MaxIncomingDataValue];

                int totalBytesReceived = 0;
                WebSocketReceiveResult? receiveResult = null;

                // receive all chunks of the message
                do
                {
                    receiveResult = await Socket.ReceiveAsync(
                        new ArraySegment<byte>(receiveBuffer, totalBytesReceived, receiveBuffer.Length - totalBytesReceived),
                        CancellationToken.None
                    );
                    totalBytesReceived += receiveResult.Count;
                } while (!receiveResult.EndOfMessage);

                if (receiveResult.MessageType == WebSocketMessageType.Close)
                {
                    if (Socket.State == WebSocketState.CloseReceived)
                        await Socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);

                    // Wait for close-handshake completion
                    while (Socket.State == WebSocketState.CloseReceived)
                        await Task.Delay(10);

                    break;
                }
                else if (receiveResult.MessageType == WebSocketMessageType.Text)
                {
                    string text = Encoding.GetString(receiveBuffer, 0, totalBytesReceived);

                    // Process
                    await ProcessMessageAsync(text);
                }
                else
                {
                    await Socket.CloseOutputAsync(WebSocketCloseStatus.InvalidMessageType, "Cannot accept binary data", CancellationToken.None);

                    // Wait for close-handshake completion
                    while (Socket.State == WebSocketState.CloseSent)
                        await Task.Delay(10);

                    break;
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "WebSocket Error");
        }
        finally
        {
            // Clean up by disposing the WebSocket once it is closed/aborted.
            Dispose();
        }
        _logger.LogDebug("Client loop stop.");
    }

    /// <summary>
    /// Stops the asynchronous loop.
    /// </summary>
    /// <remarks>
    /// This method should only be used if the client has been initialized
    /// using an existing WebSocket using this constructor: <see cref="OcppSharpClient(WebSocket, string, ProtocolVersion, ILoggerFactory?)"/>.
    /// <para>Use <see cref="Disconnect"/> in the other case instead.</para>
    /// </remarks>
    public virtual void StopLoop()
    {
        _stopLoop = true;
    }

    /// <summary>
    /// Initializes this client with a new WebSocket connection
    /// to some server.
    /// </summary>
    /// <param name="url">
    /// The URL of the server to connect to.
    /// <example>
    /// For example:
    /// <c>ws://localhost:8000/ocpp16/example_id_1234</c>
    /// </example>
    /// </param>
    /// <param name="credentials">
    /// Connection credentials. Leave set to null if none are required.
    /// <para>
    /// <example>
    /// For example:
    /// <c>new System.Net.NetworkCredential(username, password)</c>
    /// </example>
    /// </para>
    /// </param>
    /// <returns>The task object representing the asynchronous operation.</returns>
    public virtual async Task Connect(string url, ICredentials? credentials = null)
    {
        ClientWebSocket socket = new();

        socket.Options.Credentials = credentials;
        socket.Options.AddSubProtocol(OcppVersion.GetWebSocketSubProtocol());

        await socket.ConnectAsync(new Uri(url), CancellationToken.None);

        Socket = socket;
        StartLoop();
    }

    /// <summary>
    /// Disconnect from the server and close the connection.
    /// Calls <see cref="Dispose"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException">If this client has not yet been initialized with a connection.</exception>
    public virtual async void Disconnect()
    {
        if (Socket == null)
            throw UninitializedException;

        try
        {
            if (Socket.State == WebSocketState.Open)
            {
                await Socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);

                // Wait for close-handshake completion
                while (Socket.State == WebSocketState.CloseSent)
                    await Task.Delay(10);
            }
        }
        catch { }

        Dispose();
    }

    /// <summary>
    /// Registers a handler to this client instance for a specific type of OCPP-Request.
    /// </summary>
    /// <param name="payloadType">The type of request the handler is supposed to process. Must be a derived class of <see cref="RequestPayload"/>.</param>
    /// <param name="handler">The handler to be executed upon receival of a request matching the type.</param>
    /// <returns>A reference to the created <see cref="ClientRequestHandler"/>. This can be used to call <see cref="UnregisterHandler"/>.</returns>
    /// <exception cref="ArgumentException">If a handler for this specific type has already been registered or an invalid type was given.</exception>
    /// <exception cref="InvalidOperationException">If the payload is not meant to be received by a client (OCPP-Specification).</exception>
    public virtual ClientRequestHandler RegisterHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        if (handlers.Any(x => x.OnType == payloadType))
            throw new ArgumentException("A handler has already been registered for this type.", nameof(payloadType));

        OcppMessageAttribute attr = payloadType.GetCustomAttribute<OcppMessageAttribute>()
            ?? throw new ArgumentException("The supplied RequestPayload-Type does not have an OcppMessage-Attribute.", nameof(payloadType));

        if (attr.Dir == OcppMessageAttribute.Direction.PointToCentral)
            throw new InvalidOperationException($"An OCPP-Message of type '{payloadType.Name}' cannot be received by a client (charge point) as per the OCPP-Specification.");

        ClientRequestHandler result = new(payloadType, handler);
        handlers.Add(result);

        return result;
    }

    /// <summary>
    /// Registers a handler to this client instance for a specific type of OCPP-Request.
    /// </summary>
    /// <typeparam name="T">The type of request the handler is supposed to process. Must be a derived class of <see cref="RequestPayload"/>.</typeparam>
    /// <param name="handler">The handler to be executed upon receival of a request matching the type.</param>
    /// <returns>A reference to the created <see cref="ClientRequestHandler"/>. This can be used to call <see cref="UnregisterHandler"/>.</returns>
    public virtual ClientRequestHandler RegisterHandler<T>(RequestPayloadHandlerDelegateGeneric<T> handler) where T : RequestPayload
    {
        return RegisterHandler(typeof(T), (server, request) =>
        {
            return handler(server, (T)request);
        });
    }

    /// <summary>
    /// Removes a handler for a specific type of OCPP-Request.
    /// </summary>
    /// <param name="handler">
    /// A reference to a <see cref="ClientRequestHandler"/> which has been created by
    /// <para><see cref="RegisterHandler"/> or <see cref="RegisterHandler{T}"/>.</para>
    /// </param>
    /// <returns>true if the handler is successfully removed; otherwise, false.
    /// <para>This method also returns false if no handler was found.</para>
    /// <para>Or if the handler reference doesn't originate from a call to <see cref="RegisterHandler"/> or <see cref="RegisterHandler{T}"/>.</para>
    /// </returns>
    public virtual void UnregisterHandler(ClientRequestHandler handler) => handlers.Remove(handler);

    /// <summary>
    /// Sends a request to server and returns the answer.
    /// </summary>
    /// <typeparam name="T">The type of the request payload. Must derive from <see cref="RequestPayload"/>. See parameter <paramref name="payload"/>.</typeparam>
    /// <param name="payload">The payload to be sent.</param>
    /// <param name="timeoutMs">The timeout in milliseconds after which an exception is raised. (Defaults to 5000)</param>
    /// <exception cref="TimeoutException">If no response is received after <paramref name="timeoutMs"/> milliseconds.</exception>
    /// <exception cref="InvalidOperationException">If this client has not yet been initialized with a connection.</exception>
    public virtual async Task<Response> SendRequestAsync<T>(T payload, int timeoutMs = 5000) where T : RequestPayload
    {
        if (Socket == null)
            throw UninitializedException;

        // GetType() instead of T is used to get the exact type if T is inferred to be just "RequestPayload" (at the call site), if you don't explicitly specify a type between the <>
        var ocppMessageAttr = payload.GetType().GetCustomAttribute<OcppMessageAttribute>()
            ?? throw new ArgumentException("The supplied RequestPayload-Type does not have an OcppMessage-Attribute.", nameof(payload));

        string id = Guid.NewGuid().ToString(); // RequestID needn't be numeric. Easiest way to generate unique identifier
        string payloadType = ocppMessageAttr.Name;

        // Create Request object from payload
        Request request = new(id, payloadType)
        {
            Payload = payload
        };
        payload.FullRequest = request;

        string json = OcppJson.SerializeRequest(request);
        request.OriginalJsonBody = json;

        bool received = false;
        Response? response = null;

        ResponseHandlerDelegateInternal handler = (client, r) => // A temporary (local scope) event handler to wait for incoming packets
        {
            // If the Stations match and the Ids match, the response was received
            if (client != null && r.MessageId.Equals(id))
            {
                response = r;
                OcppJson.DecodeResponseFull(response, payloadType); // We can now decode the full response payload because we know the payload type
                received = true; // Set to true to exit while loop below

                ResponseReceived?.Invoke(client, r, payloadType);
            }
        };
        ResponseReceivedInternal += handler;

        _logger.LogDebug("Request: {Json}", json);

        byte[] bytes = Encoding.GetBytes(json);

        await Socket.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None); // Send the request

        RequestSent?.Invoke(this, request);

        // Wait until it is received or abort if it takes too long
        long startTime = Environment.TickCount64;
        while (!received && Environment.TickCount64 - startTime < timeoutMs)
            await Task.Delay(10); // Wait until the loop condition terminates

        ResponseReceivedInternal -= handler; // Important: unregister; otherwise they would stack the more Requests are sent

        if (response == null)
            throw new TimeoutException($"Station did not answer back within {timeoutMs}ms");

        return response;
    }

    /// <summary>
    /// This method will be called by the main message processing logic.
    /// It will call a registered handler with the request payload.
    /// </summary>
    /// <param name="payload">The request payload to be processed.</param>
    /// <returns>The response payload resulting from the processing by the handler.</returns>
    /// <exception cref="KeyNotFoundException">If no handler for this OCPP message type has been registered.</exception>
    /// <exception cref="InvalidOperationException">If the payload is not meant to be received by a client (OCPP-Specification).</exception>
    protected virtual ResponsePayload RunHandler(RequestPayload payload)
    {
        Type payloadType = payload.GetType();

        if (payloadType.GetCustomAttribute<OcppMessageAttribute>()?.Dir == OcppMessageAttribute.Direction.PointToCentral)
            throw new InvalidOperationException($"Received an OCPP-Message of type '{payloadType.Name}', which cannot be received by a client (charge point) as per the OCPP-Specification.");

        string? messageTypeName = OcppMessageAttribute.GetMessageIdentifier(payloadType);
        ClientRequestHandler? handler = handlers.FirstOrDefault(x => x.OnType == payloadType)
                                            ?? throw new KeyNotFoundException($"No handler registered for {messageTypeName}.");

        return handler.Handle(this, payload);
    }

    /// <summary>
    /// Main method executing when a message is received by the WebSocket connection.
    /// </summary>
    /// <param name="json">The raw ocpp message.</param>
    /// <returns>The task object representing the asynchronous operation.</returns>
    protected virtual async Task ProcessMessageAsync(string json)
    {
        if (Socket == null)
            throw UninitializedException;

        try
        {
            if (OcppJson.IsRequest(json))
            {
                _logger.LogDebug("Request: {Json}", json);

                // Deserialize JSON to a request object
                Request request = OcppJson.DecodeRequest(json, OcppVersion);
                request.OriginalJsonBody = json; // The original Json is saved for later use within handlers

                RequestReceived?.Invoke(this, request);

                Type payloadType = request.Payload!.GetType();
                ClientRequestHandler? handler = handlers.FirstOrDefault(x => x.OnType == payloadType);

                string? messageTypeName = OcppMessageAttribute.GetMessageIdentifier(payloadType);

                if (string.IsNullOrWhiteSpace(messageTypeName))
                {
                    throw new FormatException("Received a request with an empty message type.");
                }

                // Handle the request
                ResponsePayload payload = RunHandler(request.Payload);

                // Make and send Response
                Response response = new(request.MessageId)
                {
                    Payload = payload
                };
                payload.FullResponse = response;

                // Serialize to JSON
                json = OcppJson.SerializeResponse(response);
                response.OriginalJsonBody = json;

                _logger.LogDebug("Response: {Json}", json);

                // Send json to station
                byte[] bytes = Encoding.GetBytes(json);
                await Socket.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
                ResponseSent?.Invoke(this, response, messageTypeName);
            }
            else if (OcppJson.IsResponse(json)) // Responses to our requests are handled differently
            {
                _logger.LogDebug("Response: {Json}", json);

                // Just parse the Response "header" (everything except payload)
                Response response = OcppJson.DecodeResponseCrude(json, OcppVersion);
                response.OriginalJsonBody = json;

                // Invoke the event (Used in SendRequestAsync)
                ResponseReceivedInternal?.Invoke(this, response);
            }
            else
            {
                _logger.LogDebug("Other unhandled message: {Json}", json);  // Notifications have the id 4
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Request Error");
        }
    }

    public virtual void Dispose()
    {
        if (Disposed)
            return;
        Disposed = true;

        StopLoop();
        Socket?.Dispose();

        _logger.LogInformation("Closed WebSocket connection of client '{Id}'", Id);
        Closed?.Invoke(this, EventArgs.Empty);

        GC.SuppressFinalize(this);
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj == null)
            return false;

        if (obj is OcppSharpClient connection)
            return connection.Id.Equals(Id);

        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}