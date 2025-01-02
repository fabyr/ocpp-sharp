using System.Text;
using System.Net;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using OcppSharp.Protocol;
using OcppSharp.Client;

namespace OcppSharp.Server;

public class OcppSharpServer
{
    /// <summary>
    /// The logger instance for this server.
    /// This can be set to null to disable logging.
    /// <para>Defaults to stdout and stderr.</para>
    /// </summary>
    public Logger? Log { get; set; } = Logger.Default;

    /// <summary>
    /// The number of bytes the server will accept in a single WebSocket message.
    /// </summary>
    public int MaxIncomingData { get; set; } = 32767;

    public ProtocolVersion OcppVersion { get; }

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
    /// <para>The collection will only be cleared once the server stops. (Call to <see cref="Stop"/>)</para>
    /// <para>
    /// You will have to check <see cref="OcppSharpClient.LastCommunication"/>
    /// for finding actively connected clients.
    /// </para>
    /// <para>Or alternatively check the WebSocket-State:
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
    /// Sets up an OCPP-Server using an existing Http Listener.
    /// Only call <see cref="StartLoop"/> and <see cref="StopLoop"/> to start and stop the message processing.
    /// </summary>
    public OcppSharpServer(string urlPrefix, HttpListener listener, ProtocolVersion version)
    {
        OcppVersion = version;
        _server = listener;

        if (!urlPrefix.EndsWith('/'))
            urlPrefix += '/';
        if (!urlPrefix.StartsWith('/'))
            urlPrefix = $"/{urlPrefix}";
        SubPath = urlPrefix;
    }

    /// <summary>
    /// Sets up an OCPP-Server to listen on Port 80.
    /// </summary>
    public OcppSharpServer(string urlPrefix, ProtocolVersion version) : this(urlPrefix, version, 80)
    { }

    public OcppSharpServer(string urlPrefix, ProtocolVersion version, ushort port)
    {
        OcppVersion = version;
        _server = new HttpListener();

        if (!urlPrefix.EndsWith('/'))
            urlPrefix += '/';
        if (!urlPrefix.StartsWith('/'))
            urlPrefix = $"/{urlPrefix}";
        SubPath = urlPrefix;

        // will accept ws:// requests
        _server.Prefixes.Add($"http://+:{port}{urlPrefix}");
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
        stationMap.Clear();
        _stopLoop = false;
        try
        {
            while (!_stopLoop && _server.IsListening)
            {
                HttpListenerContext listenerContext = await _server.GetContextAsync();
                if (listenerContext.Request.IsWebSocketRequest)
                {
                    Log?.WriteLine($"Processing WebSocket Connect by {listenerContext.Request.RemoteEndPoint.Address}");

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
            Log?.WriteLineErr($"WebSocket Server Error: {ex.Message} {ex.StackTrace}");
        }

        Log?.WriteLine("Server loop stop.");
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
    /// <param name="type">The type of request the handler is supposed to process. Must be a derived class of <see cref="RequestPayload"/>.</param>
    /// <param name="handler">The handler to be executed upon receival of a request matching the type.</param>
    /// <returns>A reference to the created <see cref="ServerRequestHandler"/>. This can be used to call <see cref="UnregisterHandler"/>.</returns>
    /// <exception cref="ArgumentException">If a handler for this specific type has already been registered.</exception>
    public ServerRequestHandler RegisterHandler(Type type, RequestPayloadHandlerDelegate handler)
    {
        if (handlers.Any(x => x.OnType == type))
            throw new ArgumentException("A handler has already been registered for this type.", nameof(type));

        ServerRequestHandler result = new(type, handler);
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
        return RegisterHandler(typeof(T), (server, sender, req) =>
        {
            return handler(server, sender, (T)req);
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

    private void OnRequestReceived(OcppSharpClient sender, Request req)
    {
        RequestReceived?.Invoke(this, (OcppClientConnection)sender, req);
    }

    private void OnRequestSent(OcppSharpClient sender, Request req)
    {
        RequestSent?.Invoke(this, (OcppClientConnection)sender, req);
    }

    private void OnResponseReceived(OcppSharpClient sender, Response resp, string causeType)
    {
        ResponseReceived?.Invoke(this, (OcppClientConnection)sender, resp, causeType);
    }

    private void OnResponseSent(OcppSharpClient sender, Response resp, string causeType)
    {
        ResponseSent?.Invoke(this, (OcppClientConnection)sender, resp, causeType);
    }

    private void OnClientClosed(object? sender, EventArgs e)
    {
        UnregisterEvents((OcppClientConnection)sender!);
    }

    internal ResponsePayload RunHandler(OcppClientConnection client, RequestPayload payload)
    {
        Type payloadType = payload.GetType();
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
        string? requestUri = listenerContext.Request.RawUrl;
        string subPath = Util.SubPathFromRequestLine(requestUri);
        WebSocketContext webSocketContext;
        try
        {
            if (subPath != SubPath)
            {
                throw new Exception("Invalid sub path.");
            }

            // important: specify sub protocol
            webSocketContext = await listenerContext.AcceptWebSocketAsync(subProtocol: OcppVersion.GetWebSocketSubProtocol());
        }
        catch (Exception ex)
        {
            // The upgrade process failed somehow. For simplicity lets assume it was a failure on the part of the server and indicate this using 500.
            listenerContext.Response.StatusCode = 500;
            listenerContext.Response.Close();
            Log?.WriteLineErr($"WebSocket Error: {ex.Message} {ex.StackTrace}");
            return;
        }

        WebSocket socket = webSocketContext.WebSocket;

        // Directly set those properties on connect (no need to wait for first message)
        string stationId = Util.IdFromRequestLine(requestUri);
        OcppClientConnection client = new(this, socket, listenerContext.Request.RemoteEndPoint, stationId, OcppVersion);

        stationMap.AddOrUpdate(stationId, (key) => client, (key, existing) =>
        {
            if (!existing.Disposed)
            {
                Log?.WriteLineWarn("Station connected with a duplicate id or the old connection was not terminated gracefully!");
                existing.Disconnect();
            }

            return client;
        });

        RegisterEvents(client);

        ClientAccepted?.Invoke(this, client);

        client.StartLoop();
    }
}
