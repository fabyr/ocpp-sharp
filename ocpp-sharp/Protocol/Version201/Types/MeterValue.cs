using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct MeterValue
{
    public static readonly MeterValue Empty = new();

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Must contain atleast one entry.
    /// </summary>
    [JsonPropertyName("sampledValue")]
    public SampledValue[] SampledValue { get; set; }
}
