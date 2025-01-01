using System.Text;
using System.Net;
using System.Net.WebSockets;
using OcppSharp.Protocol;

namespace OcppSharp.Client;

public class OcppSharpClient : IDisposable
{
    public Log? Log { get; set; } = new Log(Console.Out, Console.Error);

    public int RequestResponseTimeoutMs { get; set; } = 5000;
    public int MaxIncomingData { get; set; } = 32767;

    public ProtocolVersion OcppVersion { get; }
    public string Url { get; set; }

    private bool _stopLoop = false;
    private readonly bool _needDispose;
    private readonly ClientWebSocket _client;

    public static Encoding Encoding => Encoding.UTF8;

    public string Username { get; set; }
    public string Password { get; set; }

    public bool Active { get; private set; } = false;

    private delegate void ResponseHandlerDelegateInternal(OcppSharpClient client, Response resp);

    public event ResponseHandlerDelegate? ResponseReceived;
    public event ResponseHandlerDelegate? ResponseSent;
    private event ResponseHandlerDelegateInternal? ResponseReceivedInternal;

    public event RequestHandlerDelegate? RequestReceived;
    public event RequestHandlerDelegate? RequestSent;

    private readonly List<ClientRequestHandler> handlers = [];

    public OcppSharpClient(string url, ProtocolVersion version, string user = "", string password = "", ClientWebSocket? client = null)
    {
        Url = url;
        OcppVersion = version;
        Username = user;
        Password = password;
        _needDispose = client == null;
        _client = client ?? new ClientWebSocket();
    }

    /// <summary>
    /// Starts the asynchronous Loop
    /// </summary>
    public async void StartLoop()
    {
        _stopLoop = false;
        byte[] receiveBuffer = new byte[MaxIncomingData];
        while (!_stopLoop && _client.State == WebSocketState.Open)
        {
            WebSocketReceiveResult receiveResult = await _client.ReceiveAsync(new ArraySegment<byte>(receiveBuffer, 0, receiveBuffer.Length), CancellationToken.None);

            if (receiveResult.MessageType == WebSocketMessageType.Close)
            {
                await _client.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
            }
            else if (receiveResult.MessageType == WebSocketMessageType.Text)
            {
                string text = Encoding.GetString(receiveBuffer, 0, receiveResult.Count);

                // Process
                await ProcessMessageAsync(text);
            }
            else
            {
                await _client.CloseAsync(WebSocketCloseStatus.InvalidMessageType, "Cannot accept binary data", CancellationToken.None);
            }
        }
        Log?.WriteLine("Client Loop stop.");
    }

    public async void Connect()
    {
        if (Active)
            throw new InvalidOperationException("Already connected.");
        if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            _client.Options.Credentials = new NetworkCredential(Username, Password);
        _client.Options.AddSubProtocol(OcppVersion.GetWebSocketSubProtocol());
        Log?.WriteLine($"Connecting to {Url}");
        await _client.ConnectAsync(new Uri(Url), CancellationToken.None);
        Log?.WriteLine("Connected!");
        StartLoop();
        Active = true;
    }

    public async void Disconnect()
    {
        if (!Active)
            return;
        StopLoop();
        Log?.WriteLine("Closing connection");
        await _client.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
        Log?.WriteLine("Closed!");
        Active = false;
    }

    /// <summary>
    /// Stops the asynchronous Loop
    /// </summary>
    public void StopLoop()
    {
        _stopLoop = true;
    }

    public ClientRequestHandler RegisterHandler(Type type, RequestPayloadHandlerDelegate handler)
    {
        if (handlers.Any(x => x.OnType == type))
            throw new ArgumentException("A handler has already been registered for this type.", "type");
        ClientRequestHandler result = new(type, handler);
        handlers.Add(result);
        return result;
    }

    public ClientRequestHandler RegisterHandler<T>(RequestPayloadHandlerDelegateGeneric<T> handler) where T : RequestPayload
    {
        return RegisterHandler(typeof(T), (server, req) =>
        {
            return handler(server, (T)req);
        });
    }

    public void UnregisterHandler(ClientRequestHandler handler)
    {
        handlers.Remove(handler);
    }

    /// <summary>
    /// Sends a request to the specified stations and returns the station answer. Throws exception after a certain timeout.
    /// </summary>
    /// <param name="station">The station to send the request to. Its <c>Connection</c> Property must be initialized.</param>
    /// <param name="payload">The Request Payload to contain in the Request.</param>
    public async Task<Response> SendRequestAsync<T>(T payload) where T : RequestPayload
    {
        // GetType() instead of T is used to get the exact type if T is inferred to be just "RequestPayload" (at the call site), if you don't explicitly specify a type between the <>
        var ocppMessageAttr = payload.GetType()
                                    .GetCustomAttributes(typeof(OcppMessageAttribute), true)
                                    .Cast<OcppMessageAttribute>().FirstOrDefault()
                                        ?? throw new ArgumentException("The supplied RequestPayload-Type does not have an OcppMessage-Attribute");
        string id = Guid.NewGuid().ToString(); // RequestID needn't be numeric. Easiest way to generate unique identifier
        string payloadType = ocppMessageAttr.Name;

        // Create Request object from payload
        Request req = new(2, id, payloadType)
        {
            Payload = payload
        };
        payload.FullRequest = req;

        string json = OcppJson.SerializeRequest(req);
        req.BaseJson = json;

        bool received = false;
        Response? resp = null;

        ResponseHandlerDelegateInternal handler = (client, r) => // A temporary (local scope) event handler to wait for incoming packets
        {
            // If the Stations match and the Ids match, the response was received
            if (client != null && r.MessageId.Equals(id))
            {
                resp = r;
                OcppJson.DecodeResponseFull(resp, payloadType); // We can now decode the full response payload because we know the payload type
                received = true; // Set to true to exit while loop below

                ResponseReceived?.Invoke(client, r, payloadType);
            }
        };
        ResponseReceivedInternal += handler;

        Log?.WriteVerboseLine($"Request: {json}");

        byte[] bytes = Encoding.GetBytes(json);

        await _client.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None); // Send the request

        RequestSent?.Invoke(this, req);

        // Wait until it is received or abort if it takes too long
        long startTime = Environment.TickCount64;
        while (!received && Environment.TickCount64 - startTime < RequestResponseTimeoutMs)
            await Task.Delay(20); // Wait until the loop condition terminates
        ResponseReceivedInternal -= handler; // Important: unregister; otherwise they would stack the more Requests are sent
        if (resp == null)
            throw new Exception("Timeout: Server did not answer back.");
        return resp;
    }

    // Main Method executing when a Message is received by the WebSocket server
    private async Task ProcessMessageAsync(string json)
    {
        try
        {
            if (OcppJson.IsRequest(json))
            {
                Log?.WriteVerboseLine($"Request: {json}");

                // Deserialize JSON to a request object
                Request req = OcppJson.DecodeRequest(json, OcppVersion);
                req.BaseJson = json; // The original Json is saved for database purposes

                RequestReceived?.Invoke(this, req);

                if (req.Payload == null)
                    throw new NullReferenceException("Payload was null");

                Type t = req.Payload.GetType();
                ClientRequestHandler? handler = handlers.FirstOrDefault(x => x.OnType == t);
                string? mIdent = Util.GetMessageIdentifier(t);
                if (mIdent == null || handler == null)
                {
                    Log?.WriteLineWarn($"No handler registered for {mIdent}.");
                    return;
                }

                // Handle the request
                ResponsePayload payload = handler.Handle(this, req.Payload);

                // Make and send Response
                Response resp = new(3, req.MessageId)
                {
                    Payload = payload
                };
                payload.FullResponse = resp;

                // Serialize to JSON
                json = OcppJson.SerializeResponse(resp);
                resp.BaseJson = json;

                Log?.WriteVerboseLine($"Response: {json}");

                // Send json to station
                byte[] bytes = Encoding.GetBytes(json);
                await _client.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
                ResponseSent?.Invoke(this, resp, mIdent);
            }
            else
            // Responses to our requests are handled differently
            {
                Log?.WriteVerboseLine($"Response: {json}");

                // Just parse the Response "header" (everything except payload)
                Response resp = OcppJson.DecodeResponseCrude(json, OcppVersion);
                resp.BaseJson = json;

                // Invoke the event (Used in SendRequestAsync)
                ResponseReceivedInternal?.Invoke(this, resp);
            }
        }
        catch (Exception ex)
        {
            Log?.WriteLineErr($"Request Error: {ex.Message} {ex.StackTrace}");
        }
    }

    public void Dispose()
    {
        if (_needDispose)
            _client.Dispose();
        GC.SuppressFinalize(this);
    }
}
