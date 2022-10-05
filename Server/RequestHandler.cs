using System;
using OcppSharp.Protocol;

namespace OcppSharp.Server
{
    public class RequestHandler
    {
        public delegate ResponsePayload RequestHandlerDelegate(OcppSharpServer server, OcppClientConnection station, Request req);

        public Type OnType { get; }
        public RequestHandlerDelegate Handler { get; }

        private long Identity { get; }

        public RequestHandler(Type t, RequestHandlerDelegate handler)
        {
            this.OnType = t;
            this.Handler = handler;
            Identity = Util.NewID64();
        }

        public static implicit operator RequestHandlerDelegate(RequestHandler value)
        {
            return value.Handler;
        }

        public ResponsePayload Handle(OcppSharpServer server, OcppClientConnection station, Request req)
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