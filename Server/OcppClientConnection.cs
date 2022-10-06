using System;
using System.Net.WebSockets;
using OcppSharp.Protocol;

namespace OcppSharp.Server
{
    public class OcppClientConnection
    {
        public OcppSharpServer ParentServer { get; }
        public WebSocket? Socket { get; set; }
        public System.Net.IPEndPoint? EndPoint { get; set; }
        public ProtocolVersion OcppVersion { get; }

        /// <summary>
        /// The ID the Station identifies with.
        /// </summary>
        public string ID { get; private set; }
        public DateTime LastCommunication { get; set; }

        public OcppClientConnection(OcppSharpServer server, WebSocket? sock, ProtocolVersion ver, string id)
        {
            ParentServer = server;
            Socket = sock;
            OcppVersion = ver;
            ID = id;
        }

        public OcppClientConnection(OcppSharpServer server, ProtocolVersion ver, string id) : this(server, null, ver, id)
        { }

        public override bool Equals(object? obj)
        {
            if(obj == null || !(obj is OcppClientConnection))
                return false;
            
            return ((OcppClientConnection)obj).ID.Equals(this.ID);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        public async Task<Response> SendRequestAsync<T>(T payload) where T : RequestPayload
        {
            return await ParentServer.SendRequestAsync<T>(this, payload);
        }
    }
}