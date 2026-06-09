using System.Text.Json.Serialization;

namespace OcppSharp.Protocol;

public abstract class RequestPayload
{
    [JsonIgnore]
    public Request? FullRequest { get; set; }
}
