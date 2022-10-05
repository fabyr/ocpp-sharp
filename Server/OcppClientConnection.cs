using System;
using System.Net.WebSockets;

namespace OcppSharp.Server
{
    public class OcppClientConnection
    {
        public WebSocket? Socket { get; set; }
        public ProtocolVersion OcppVersion { get; }
        public string ID { get; private set; }
        public DateTime LastCommunication { get; set; }

        public OcppClientConnection(WebSocket? sock, ProtocolVersion ver, string id)
        {
            Socket = sock;
            OcppVersion = ver;
            ID = id;
        }

        public OcppClientConnection(ProtocolVersion ver, string id) : this(null, ver, id)
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
    }
}