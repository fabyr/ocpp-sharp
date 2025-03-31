using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using OcppSharp.Client;
using OcppSharp.Protocol;
using System.Collections.Concurrent;
using System.Net;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace OcppSharp.Server;

public partial class OcppSharpServer
{
    [GeneratedRegex(@"^(\/?(?:.*?\/)+?)([^\/]*?)\/?$", RegexOptions.Singleline)]
    private static partial Regex PathRegex();

    private readonly ILogger<OcppSharpServer> _logger;
    private readonly ILoggerFactory _loggerFactory;

    /// <summary>
    /// The number of bytes the server will accept in a single WebSocket message.
    /// </summary>
    public int MaxIncomingData { get; set; } = 32767;

    public IEnumerable<ProtocolVersion> OcppVersions { get; }

    public string SubPath { get; }

    /// <summary>
    /// true, if the server has been started; false, if it is in a stopped state.
    /// </summary>
    /// <remarks>
    /// If this server has been initialized with an existing <see cref="HttpListener"/>,
    /// this property will always stay false.
    /// </remarks>
    public bool Active { get; private set; } = false;

    /// <summary>
    /// The encoding used for encoding and decoding WebSocket data.
    /// <para>Defaults to <see cref="Encoding.UTF8"/></para>
    /// </summary>
    public static Encoding Encoding { get; set; } = Encoding.UTF8;

    /// <summary>
    /// Returns a string array containing only the IDs of all stations.
    /// </summary>
    /// <remarks>
    /// Note: Clients won't be removed after they have connected once.
    /// <para>See <see cref="ConnectedClients"/> for more information.</para>
    /// </remarks>
    public string[] AllStationIds => ConnectedClients.Select(client => client.Id).ToArray();

    /// <summary>
    /// A collection of connected clients (<see cref="OcppClientConnection"/>).
    /// </summary>
    /// <remarks>
    /// Note: Clients won't be removed after they have connected once.
    /// <para>
    /// The collection will only be cleared once the server itself restarts.
    /// You will have to check <see cref="OcppSharpClient.LastCommunication"/>
    /// for finding actively connected clients.
    /// </para>
    /// <para>
    /// Or alternatively check the WebSocket-State:
    /// <code>
    /// station.Socket?.State == WebSocketState.Open
    /// </code>
    /// </para>
    /// </remarks>
    public ICollection<OcppClientConnection> ConnectedClients => stationMap.Values;

    public event ResponseHandlerDelegate? ResponseReceived;

    public event ResponseHandlerDelegate? ResponseSent;

    public event RequestHandlerDelegate? RequestReceived;

    public event RequestHandlerDelegate? RequestSent;

    public event EventHandler<OcppClientConnection>? ClientAccepted;

    private bool _stopLoop = false;
    private readonly HttpListener _server;
    private readonly ConcurrentDictionary<string, OcppClientConnection> stationMap = new();
    private readonly List<ServerRequestHandler> handlers = [];

    /// <summary>
    /// Sets up an OCPP-Server (WebSocket-Server) using an existing <see cref="HttpListener"/> instance.
    /// Only call <see cref="StartLoop"/> and <see cref="StopLoop"/> to start and stop the message processing.
    /// </summary>
    /// <param name="urlPrefix">The path for the websocket endpoint.</param>
    /// <param name="listener">
    /// The existing instance of <see cref="HttpListener"/>.<br/>
    /// Note: This listener must be externally started and stopped
    /// and have its Prefixes correctly configured.
    /// </param>
    /// <param name="versions">The ocpp protocol versions this server allows.</param>
    /// <param name="loggerFactory">Optional logger factory.</param>
    public OcppSharpServer(string urlPrefix, HttpListener listener, IEnumerable<ProtocolVersion> versions, ILoggerFactory? loggerFactory = null) : this(urlPrefix, versions, 80, listener, loggerFactory)
    { }

    /// <summary>
    /// Sets up an OCPP-Server (WebSocket-Server) to listen on port 80.
    /// </summary>
    /// <param name="urlPrefix">The path for the websocket endpoint.</param>
    /// <param name="versions">The ocpp protocol versions this server allows.</param>
    /// <param name="loggerFactory">Optional logger factory.</param>
    public OcppSharpServer(string urlPrefix, IEnumerable<ProtocolVersion> versions, ILoggerFactory? loggerFactory = null) : this(urlPrefix, versions, 80, loggerFactory)
    { }

    /// <summary>
    /// Sets up an OCPP-Server (WebSocket-Server) to listen on the specified port.
    /// </summary>
    /// <param name="urlPrefix">The path for the websocket endpoint.</param>
    /// <param name="versions">The ocpp protocol versions this server allows.</param>
    /// <param name="port">The port to listen on for incoming connections.</param>
    /// <param name="loggerFactory">Optional logger factory.</param>
    public OcppSharpServer(string urlPrefix, IEnumerable<ProtocolVersion> versions, ushort port, ILoggerFactory? loggerFactory = null) : this(urlPrefix, versions, port, null, loggerFactory)
    { }

    private OcppSharpServer(string urlPrefix, IEnumerable<ProtocolVersion> versions, ushort port = 80, HttpListener? listener = null, ILoggerFactory? loggerFactory = null)
    {
        OcppVersions = versions;
        _server = listener ?? new HttpListener();

        _loggerFactory = loggerFactory ?? NullLoggerFactory.Instance;
        _logger = _loggerFactory.CreateLogger<OcppSharpServer>();

        if (!urlPrefix.EndsWith('/'))
            urlPrefix += '/';
        if (!urlPrefix.StartsWith('/'))
            urlPrefix = $"/{urlPrefix}";
        SubPath = urlPrefix;

        if (listener == null)
        {
            // will accept ws:// requests
            _server.Prefixes.Add($"http://localhost:{port}{urlPrefix}");
        }
    }

    /// <summary>
    /// Starts listening for incoming connections.
    /// </summary>
    /// <exception cref="InvalidOperationException">If the server has already been started.</exception>
    public void Start()
    {
        if (Active)
            throw new InvalidOperationException("Already started.");
        _server.Start();
        StartLoop();
        Active = true;
    }

    /// <summary>
    /// Stops listening for incoming connections.
    /// <para>This method can be called multiple times, even if the server has already been stopped.</para>
    /// </summary>
    public void Stop()
    {
        if (!Active)
            return;

        try
        {
            foreach (OcppClientConnection client in ConnectedClients)
            {
                client.Disconnect();
            }
        }
        catch { }

        StopLoop();
        _server.Stop();
        Active = false;
    }

    /// <summary>
    /// Starts the asynchronous loop.
    /// </summary>
    /// <remarks>
    /// This method should only be used if the server has been initialized
    /// using an existing <see cref="HttpListener"/>.
    /// <para>Use <see cref="Start"/> in the other case instead.</para>
    /// </remarks>
    public async void StartLoop()
    {
        _logger.LogDebug("Server loop start.");
        stationMap.Clear();
        _stopLoop = false;
        try
        {
            while (!_stopLoop && _server.IsListening)
            {
                HttpListenerContext listenerContext = await _server.GetContextAsync();
                if (listenerContext.Request.IsWebSocketRequest)
                {
                    _logger.LogInformation("Processing WebSocket Connect by {RemoteAddress}", listenerContext.Request.RemoteEndPoint.Address);

                    ProcessRequestAsync(listenerContext);
                }
                else
                {
                    listenerContext.Response.StatusCode = 400;
                    listenerContext.Response.Close();
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "WebSocket Server Error");
        }

        _logger.LogDebug("Server loop stop.");
    }

    /// <summary>
    /// Stops the asynchronous loop.
    /// </summary>
    /// <remarks>
    /// This method should only be used if the server has been initialized
    /// using an existing <see cref="HttpListener"/>.
    /// <para>Use <see cref="Stop"/> in the other case instead.</para>
    /// </remarks>
    public void StopLoop()
    {
        _stopLoop = true;
    }

    /// <summary>
    /// Returns a station object by its id.
    /// </summary>
    /// <exception cref="KeyNotFoundException">If no station with that id exists.</exception>

    public OcppClientConnection GetStation(string id)
    {
        if (stationMap.TryGetValue(id, out OcppClientConnection? result))
        {
            return result;
        }
        else
            throw new KeyNotFoundException($"The Station with id '{id}' does not exist.");
    }

    /// <summary>
    /// Registers a handler to this server instance for a specific type of OCPP-Request.
    /// </summary>
    /// <param name="payloadType">The type of request the handler is supposed to process. Must be a derived class of <see cref="RequestPayload"/>.</param>
    /// <param name="handler">The handler to be executed upon receival of a request matching the type.</param>
    /// <returns>A reference to the created <see cref="ServerRequestHandler"/>. This can be used to call <see cref="UnregisterHandler"/>.</returns>
    /// <exception cref="ArgumentException">If a handler for this specific type has already been registered or an invalid type was given.</exception>
    /// <exception cref="InvalidOperationException">If the payload is not meant to be received by a server (OCPP-Specification).</exception>
    public ServerRequestHandler RegisterHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        if (handlers.Any(x => x.OnType == payloadType))
            throw new ArgumentException("A handler has already been registered for this type.", nameof(payloadType));

        OcppMessageAttribute attr = payloadType.GetCustomAttribute<OcppMessageAttribute>()
            ?? throw new ArgumentException("The supplied RequestPayload-Type does not have an OcppMessage-Attribute.", nameof(payloadType));

        if (attr.Dir == OcppMessageAttribute.Direction.CentralToPoint)
            throw new InvalidOperationException($"An OCPP-Message of type '{payloadType.Name}' cannot be received by a server (central system) as per the OCPP-Specification.");

        ServerRequestHandler result = new(payloadType, handler);
        handlers.Add(result);

        return result;
    }

    /// <summary>
    /// Registers a handler to this server instance for a specific type of OCPP-Request.
    /// </summary>
    /// <typeparam name="T">The type of request the handler is supposed to process. Must be a derived class of <see cref="RequestPayload"/>.</typeparam>
    /// <param name="handler">The handler to be executed upon receival of a request matching the type.</param>
    /// <returns>A reference to the created <see cref="ServerRequestHandler"/>. This can be used to call <see cref="UnregisterHandler"/>.</returns>
    public ServerRequestHandler RegisterHandler<T>(RequestPayloadHandlerDelegateGeneric<T> handler) where T : RequestPayload
    {
        return RegisterHandler(typeof(T), (server, sender, request) =>
        {
            return handler(server, sender, (T)request);
        });
    }

    /// <summary>
    /// Removes a handler for a specific type of OCPP-Request.
    /// </summary>
    /// <param name="handler">
    /// A reference to a <see cref="ServerRequestHandler"/> which has been created by
    /// <para><see cref="RegisterHandler"/> or <see cref="RegisterHandler{T}"/>.</para>
    /// </param>
    /// <returns>true if the handler is successfully removed; otherwise, false.
    /// <para>This method also returns false if no handler was found.</para>
    /// <para>Or if the handler reference doesn't originate from a call to <see cref="RegisterHandler"/> or <see cref="RegisterHandler{T}"/>.</para>
    /// </returns>
    public bool UnregisterHandler(ServerRequestHandler handler) => handlers.Remove(handler);

    private void OnRequestReceived(OcppSharpClient sender, Request request)
    {
        RequestReceived?.Invoke(this, (OcppClientConnection)sender, request);
    }

    private void OnRequestSent(OcppSharpClient sender, Request request)
    {
        RequestSent?.Invoke(this, (OcppClientConnection)sender, request);
    }

    private void OnResponseReceived(OcppSharpClient sender, Response response, string causeType)
    {
        ResponseReceived?.Invoke(this, (OcppClientConnection)sender, response, causeType);
    }

    private void OnResponseSent(OcppSharpClient sender, Response response, string causeType)
    {
        ResponseSent?.Invoke(this, (OcppClientConnection)sender, response, causeType);
    }

    private void OnClientClosed(object? sender, EventArgs e)
    {
        UnregisterEvents((OcppClientConnection)sender!);
    }

    internal ResponsePayload RunHandler(OcppClientConnection client, RequestPayload payload)
    {
        Type payloadType = payload.GetType();

        if (payloadType.GetCustomAttribute<OcppMessageAttribute>()?.Dir == OcppMessageAttribute.Direction.CentralToPoint)
            throw new InvalidOperationException($"Received an OCPP-Message of type '{payloadType.Name}', which cannot be received by a server (central system) as per the OCPP-Specification.");

        string? messageTypeName = OcppMessageAttribute.GetMessageIdentifier(payloadType);
        ServerRequestHandler? handler = handlers.FirstOrDefault(x => x.OnType == payloadType)
                                            ?? throw new KeyNotFoundException($"No handler registered for {messageTypeName}.");

        return handler.Handle(this, client, payload);
    }

    private void RegisterEvents(OcppClientConnection client)
    {
        client.RequestReceived += OnRequestReceived;
        client.RequestSent += OnRequestSent;
        client.ResponseReceived += OnResponseReceived;
        client.ResponseSent += OnResponseSent;
        client.Closed += OnClientClosed;
    }

    private void UnregisterEvents(OcppClientConnection client)
    {
        client.RequestReceived -= OnRequestReceived;
        client.RequestSent -= OnRequestSent;
        client.ResponseReceived -= OnResponseReceived;
        client.ResponseSent -= OnResponseSent;
        client.Closed -= OnClientClosed;
    }

    // Processes an incoming upgrade request (first connection of a station)
    // Continously handles subsequent messages
    private async void ProcessRequestAsync(HttpListenerContext listenerContext)
    {
        string requestUri = listenerContext.Request.RawUrl ?? string.Empty;
        void AbortBadRequest()
        {
            listenerContext.Response.StatusCode = 400;
            listenerContext.Response.Close();
            _logger.LogWarning("Client connected with a malformed url, terminating connection. ({Url})", requestUri);
        }

        Match pathMatch = PathRegex().Match(requestUri);

        if (!pathMatch.Success)
        {
            AbortBadRequest();
            return;
        }

        string subPath = pathMatch.Groups[1].Value;
        string stationId = pathMatch.Groups[2].Value;
        if (string.IsNullOrWhiteSpace(stationId) || subPath != SubPath)
        {
            AbortBadRequest();
            return;
        }

        try
        {
            ProtocolVersion? ocppVersion = null;

            var subProtocolHeader = listenerContext.Request.Headers["Sec-WebSocket-Protocol"];
            if (!string.IsNullOrEmpty(subProtocolHeader))
            {
                var requestedSubProtocols = subProtocolHeader.Split(',');
                foreach (var version in OcppVersions)
                {
                    if (requestedSubProtocols.Any(x => string.Equals(x.Trim(), version.GetWebSocketSubProtocol(), StringComparison.OrdinalIgnoreCase)))
                    {
                        ocppVersion = version;
                        break;
                    }
                }
            }

            if (ocppVersion == null)
            {
                _logger.LogWarning("OCPP Version not supported, protocol header: ({ProtocolHeader})", subProtocolHeader);
                ocppVersion = OcppVersions.First();
            }

            WebSocketContext webSocketContext = await listenerContext.AcceptWebSocketAsync(subProtocol: ocppVersion.Value.GetWebSocketSubProtocol());

            WebSocket socket = webSocketContext.WebSocket;

            // Directly set those properties on connect (no need to wait for first message)
            OcppClientConnection client = new(this, socket, listenerContext.Request.RemoteEndPoint, stationId, ocppVersion.Value, _loggerFactory);

            stationMap.AddOrUpdate(stationId, (key) => client, (key, existing) =>
            {
                if (!existing.Disposed)
                {
                    _logger.LogWarning("Station ({StationId}) connected with a duplicate id or the old connection was not terminated gracefully!", key);
                    existing.Disconnect();
                }

                return client;
            });

            RegisterEvents(client);

            ClientAccepted?.Invoke(this, client);

            client.StartLoop();
        }
        catch (Exception ex)
        {
            // The upgrade process failed somehow or there was an error creating the OcppClient.
            // For simplicity lets assume it was a failure on the part of the server and indicate this using 500.
            listenerContext.Response.StatusCode = 500;
            listenerContext.Response.Close();
            _logger.LogError(ex, "WebSocket accept error");
            return;
        }
    }
}
