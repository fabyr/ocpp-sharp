using Newtonsoft.Json;

namespace OcppSharp.Protocol;

public abstract class RequestPayload
{
    [JsonIgnore]
    public Request? FullRequest { get; set; }
}
