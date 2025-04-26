using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct MeterValue
{
    public static readonly MeterValue Empty = new();

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("sampledValue")]
    public SampledValue[]? SampledValue { get; set; }
}
