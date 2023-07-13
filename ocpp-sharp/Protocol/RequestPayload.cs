using System;

namespace OcppSharp.Protocol
{
    public abstract class RequestPayload
    {
        [Newtonsoft.Json.JsonIgnore]
        public Request? FullRequest { get; set; }
    }
}