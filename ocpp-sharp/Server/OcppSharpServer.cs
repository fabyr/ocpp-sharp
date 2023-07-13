using System;
using System.Net;
using System.Collections.Concurrent;
using Newtonsoft.Json;
using System.IO;
using System.Net.WebSockets;
using OcppSharp.Protocol;

namespace OcppSharp.Server
{
    public class OcppSharpServer
    {
        public Log? Log { get; set; } = new Log(Console.Out, Console.Error);

        public int RequestResponseTimeoutMs { get; set; } = 5000;
        public int MaxIncomingData { get; set; } = 32767;

        public ProtocolVersion OcppVersion { get; }
        public string SubPath { get; }

        private bool _stopLoop = false;

        /// <summary>
        /// Returns a string array containing only the IDs of all stations
        /// </summary>
        public string[] AllStationIds => stationMap.Values.Select(x => x.ID).ToArray();
        
        private HttpListener _server;
        public System.Text.Encoding Encoding => System.Text.Encoding.UTF8;

        private ConcurrentDictionary<string, OcppClientConnection> stationMap = new ConcurrentDictionary<string, OcppClientConnection>();
        private delegate void ResponseHandlerDelegateInternal(OcppSharpServer server, OcppClientConnection sender, Response resp);

        public event ResponseHandlerDelegate? ResponseReceived;
        public event ResponseHandlerDelegate? ResponseSent;
        private event ResponseHandlerDelegateInternal? ResponseReceivedInternal;

        public event RequestHandlerDelegate? RequestReceived;
        public event RequestHandlerDelegate? RequestSent;
        public event EventHandler<OcppClientConnection>? WebSocketAccepted;

        private List<RequestHandler> handlers = new List<RequestHandler>();
        
        /// <summary>
        /// Sets up an OCPP-Server using an existing Http Listener.
        /// Only call StartLoop and StopLoop to start and stop the message processing.
        /// </summary>
        public OcppSharpServer(string urlPrefix, HttpListener listener, ProtocolVersion proto)
        {
            OcppVersion = proto;
            _server = listener;

            if(!urlPrefix.EndsWith("/"))
                urlPrefix += "/";
            if(!urlPrefix.StartsWith("/"))
                urlPrefix = "/" + urlPrefix;
            SubPath = urlPrefix;
        }

        /// <summary>
        /// Sets up an OCPP-Server to listen on Port 80.
        /// </summary>
        public OcppSharpServer(string urlPrefix, ProtocolVersion proto) : this(urlPrefix, proto, 80)
        { }
        
        public OcppSharpServer(string urlPrefix, ProtocolVersion proto, ushort port)
        {
            OcppVersion = proto;
            _server = new HttpListener();

            if(!urlPrefix.EndsWith("/"))
                urlPrefix += "/";
            if(!urlPrefix.StartsWith("/"))
                urlPrefix = "/" + urlPrefix;
            SubPath = urlPrefix;

            // will accept ws:// requests
            _server.Prefixes.Add("http://+:" + port + urlPrefix);
        }
        
        /// <summary>
        /// Starts the asynchronous Loop
        /// </summary>
        public async void StartLoop()
        {
            _stopLoop = false;
            while (!_stopLoop && _server.IsListening)
            {
                HttpListenerContext listenerContext = await _server.GetContextAsync();
                if (listenerContext.Request.IsWebSocketRequest)
                {
                    Log?.WriteLine($"Processing WebSocket Connect by {listenerContext.Request.RemoteEndPoint.Address}");
                    ProcessRequestAsync(listenerContext); // we don't await here to continue listening for other stations immediately
                }
                else
                {
                    listenerContext.Response.StatusCode = 400;
                    listenerContext.Response.Close();
                }
            }
            Log?.WriteLine("Server Loop stop.");
        }

        public void Start()
        {
            _server.Start();
            StartLoop();
        }

        public void Stop()
        {
            StopLoop();
            _server.Stop();
        }

        /// <summary>
        /// Stops the asynchronous Loop
        /// </summary>
        public void StopLoop()
        {
            _stopLoop = true;
        }

        /// <summary>
        /// Returns a Station Object by its id.
        /// Only accesses the in-memory dictionary, not the database.
        /// </summary>
        public OcppClientConnection GetStation(string id)
        {
            if(stationMap.ContainsKey(id))
            {
                return stationMap[id];
            }
            else
                throw new Exception("The requested Station does not exist.");
        }

        public RequestHandler RegisterHandler(Type type, RequestPayloadHandlerDelegate handler)
        {
            if(handlers.Any(x => x.OnType == type))
                throw new ArgumentException("A handler has already been registered for this type.", "type");
            RequestHandler result = new RequestHandler(type, handler);
            handlers.Add(result);
            return result;
        }

        public RequestHandler RegisterHandler<T>(RequestPayloadHandlerDelegateGeneric<T> handler) where T : RequestPayload
        {
            return RegisterHandler(typeof(T), (server, sender, req) =>
            {
                return handler(server, sender, (T)req);
            });
        }

        public void UnregisterHandler(RequestHandler handler)
        {
            handlers.Remove(handler);
        }

        /// <summary>
        /// Sends a request to the specified stations and returns the station answer. Throws exception after a certain timeout.
        /// </summary>
        /// <param name="station">The station to send the request to. Its <c>Connection</c> Property must be initialized.</param>
        /// <param name="payload">The Request Payload to contain in the Request.</param>
        public async Task<Response> SendRequestAsync<T>(OcppClientConnection station, T payload) where T : RequestPayload
        {
            // GetType() instead of T is used to get the exact type if T is inferred to be just "RequestPayload" (at the call site), if you don't explicitly specify a type between the <>
            var ocppMessageAttr = payload.GetType().GetCustomAttributes(typeof(Protocol.OcppMessageAttribute), true).Cast<Protocol.OcppMessageAttribute>().FirstOrDefault();
            if(ocppMessageAttr == null)
                throw new ArgumentException("The supplied RequestPayload-Type does not have an OcppMessage-Attribute");
            if(station.OcppVersion != ocppMessageAttr.Version)
                throw new ArgumentException("The station operates on a different protocol version than the supplied payload");
            string id = Guid.NewGuid().ToString(); // RequestID needn't be numeric. Easiest way to generate unique identifier
            string payloadType = ocppMessageAttr.Name;

            // Create Request object from payload
            Request req = new Protocol.Request(2, id, payloadType);
            req.Payload = payload;
            payload.FullRequest = req;

            string json = OcppJson.SerializeRequest(req);
            req.BaseJson = json;
            
            bool received = false;
            Response? resp = null;

            ResponseHandlerDelegateInternal handler = (server, sender, r) => // A temporary (local scope) event handler to wait for incoming packets
            {
                // If the Stations match and the Ids match, the response was received
                if(sender != null && sender.Equals(station) && r.MessageId.Equals(id))
                {
                    resp = r;
                    OcppJson.DecodeResponseFull(resp, payloadType); // We can now decode the full response payload because we know the payload type
                    received = true; // Set to true to exit while loop below

                    ResponseReceived?.Invoke(server, sender, r, payloadType);
                }
            };
            ResponseReceivedInternal += handler;
            
            if(station.Socket == null || station.Socket.State != WebSocketState.Open)
                throw new Exception("The specified station has not yet initialized a connection.");
            Log?.WriteVerboseLine($"Request (to {station.ID}): {json}");
            
            byte[] bytes = Encoding.GetBytes(json);

            await station.Socket.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None); // Send the request

            RequestSent?.Invoke(this, station, req);

            // Wait until it is received or abort if it takes too long
            long startTime = Environment.TickCount64;
            while(!received && Environment.TickCount64 - startTime < RequestResponseTimeoutMs)
                await Task.Delay(20); // Wait until the loop condition terminates
            ResponseReceivedInternal -= handler; // Important: unregister; otherwise they would stack the more Requests are sent
            if(resp == null)
                throw new Exception("Timeout: Station did not answer back.");
            return resp;
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
                if(subPath != SubPath)
                {
                    throw new Exception("Invalid sub path.");
                }
                // important: specify sub protocol
                webSocketContext = await listenerContext.AcceptWebSocketAsync(subProtocol: OcppVersion.GetWebSocketSubProtocol());
            }
            catch(Exception ex)
            {
                // The upgrade process failed somehow. For simplicity lets assume it was a failure on the part of the server and indicate this using 500.
                listenerContext.Response.StatusCode = 500;
                listenerContext.Response.Close();
                Log?.WriteLineErr($"WebSocket Error: {ex.Message} {ex.StackTrace}");
                return;
            }
            
            WebSocket webSocket = webSocketContext.WebSocket;                                           

            // Directly set those properties on connect (no need to wait for first message)
            string statId = Util.IdFromRequestLine(requestUri);
            OcppClientConnection s = RegisterStation(statId);
            s.Socket = webSocket;
            s.EndPoint = (System.Net.IPEndPoint)listenerContext.Request.RemoteEndPoint;
            WebSocketAccepted?.Invoke(this, s);
            
            try
            {
                //### Receiving
                // Define a receive buffer to hold data received on the WebSocket connection. The buffer will be reused as we only need to hold on to the data
                // long enough to send it back to the sender.
                byte[] receiveBuffer = new byte[MaxIncomingData];

                // While the WebSocket connection remains open run a simple loop that receives data and sends it back.
                while (webSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);

                    if (receiveResult.MessageType == WebSocketMessageType.Close)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                    }
                    else if (receiveResult.MessageType == WebSocketMessageType.Text)
                    {                    
                        string text = Encoding.GetString(receiveBuffer, 0, receiveResult.Count);
                        
                        // Process
                        await ProcessMessageAsync(listenerContext, webSocket, text);
                    }
                    else
                    {                        
                        await webSocket.CloseAsync(WebSocketCloseStatus.InvalidMessageType, "Cannot accept binary data", CancellationToken.None);
                    }
                }
            }
            catch(Exception ex)
            {
                Log?.WriteLineErr($"WebSocket Error: {ex.Message} {ex.StackTrace}");
            }
            finally
            {
                // Clean up by disposing the WebSocket once it is closed/aborted.
                if (webSocket != null)
                    webSocket.Dispose();
            }
        }

        public OcppClientConnection RegisterStation(string stationId)
        {
            OcppClientConnection result;
            // Create a station object if it doesn't exist. 
            // In both cases assign it to the request so the handler knows who sent the request
            if(stationMap.ContainsKey(stationId))
            {
                result = stationMap[stationId];
            } else
            {
                if(!stationMap.TryAdd(stationId, result = new OcppClientConnection(this, OcppVersion, stationId)))
                    throw new Exception("Could not register station.");
            }
            return result;
        }

        // Main Method executing when a Message is received by the WebSocket server
        private async Task ProcessMessageAsync(HttpListenerContext listenerContext, WebSocket sock, string json)
        {
            try
            {
                // get the <Station ID> from the URL according to ws://<IP>/.../<Station ID>
                string stationId = Util.IdFromRequestLine(listenerContext.Request.RawUrl);

                if(OcppJson.IsRequest(json))
                {
                    Log?.WriteVerboseLine($"Request (from {stationId}): {json}");

                    // Deserialize JSON to a request object
                    Request req = OcppJson.DecodeRequest(json, OcppVersion);
                    req.BaseJson = json; // The original Json is saved for database purposes
                    
                    OcppClientConnection stat = RegisterStation(stationId);
                    
                    RequestReceived?.Invoke(this, stat, req);

                    if(req.Payload == null)
                        throw new NullReferenceException("Payload was null");
                    
                    Type t = req.Payload.GetType();
                    RequestHandler? handler = handlers.FirstOrDefault(x => x.OnType == t);
                    string? mIdent = Util.GetMessageIdentifier(t);
                    if(mIdent == null || handler == null)
                    {
                        Log?.WriteLineWarn($"No handler registered for {mIdent}.");
                        return;
                    }

                    // Handle the request
                    ResponsePayload payload = handler.Handle(this, stat, req.Payload);
                    
                    // Make and send Response
                    Response resp = new Response(3, req.MessageId);
                    resp.Payload = payload;
                    payload.FullResponse = resp;

                    // Serialize to JSON
                    json = OcppJson.SerializeResponse(resp);
                    resp.BaseJson = json;
                    
                    Log?.WriteVerboseLine($"Response (to {stationId}): {json}");

                    // Send json to station
                    byte[] bytes = Encoding.GetBytes(json);
                    await sock.SendAsync(bytes, WebSocketMessageType.Text, true, CancellationToken.None);
                    ResponseSent?.Invoke(this, stat, resp, mIdent);
                } else
                // Responses to our requests are handled differently
                {
                    Log?.WriteVerboseLine($"Response (from {stationId}): {json}");

                    // Just parse the Response "header" (everything except payload)
                    Response resp = OcppJson.DecodeResponseCrude(json, OcppVersion);
                    resp.BaseJson = json;
                    
                    // Invoke the event (Used in SendRequestAsync)
                    ResponseReceivedInternal?.Invoke(this, RegisterStation(stationId), resp);
                }

                // If everything above succeeded
                OcppClientConnection s = RegisterStation(stationId);
                s.LastCommunication = DateTime.Now; // If a valid packet was received, update the time
            } catch(Exception ex)
            {
                Log?.WriteLineErr($"Request Error: {ex.Message} {ex.StackTrace}");
            }
        }
    }
}