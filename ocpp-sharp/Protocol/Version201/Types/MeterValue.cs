using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct MeterValue
{
    public static readonly MeterValue Empty = new();

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Must contain atleast one entry.
    /// </summary>
    [JsonProperty("sampledValue")]
    public SampledValue[] SampledValue { get; set; }
}
