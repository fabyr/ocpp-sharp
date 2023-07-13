using System;
using OcppSharp.Protocol;

namespace OcppSharp.Server
{
    public class RequestHandler
    {
        public Type OnType { get; }
        public RequestPayloadHandlerDelegate Handler { get; }

        private long Identity { get; }

        public RequestHandler(Type t, RequestPayloadHandlerDelegate handler)
        {
            this.OnType = t;
            this.Handler = handler;
            Identity = Util.NewID64();
        }

        public ResponsePayload Handle(OcppSharpServer server, OcppClientConnection station, RequestPayload req)
        {
            return Handler(server, station, req);
        }

        public override int GetHashCode()
        {
            return (int)(Identity & int.MaxValue);
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || !(obj is RequestHandler))
                return false;
            return ((RequestHandler)obj).Identity == Identity;
        }
    }
}