using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct MeterValue
{
    public static readonly MeterValue Empty = new();

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("sampledValue")]
    public SampledValue[]? SampledValue { get; set; }
}
