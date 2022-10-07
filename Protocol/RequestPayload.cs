using System;

namespace OcppSharp.Protocol
{
    public abstract class RequestPayload
    {
        public Request? FullRequest { get; set; }
    }
}