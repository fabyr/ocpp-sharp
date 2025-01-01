using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetMonitoringData
{
    public static readonly SetMonitoringData Empty = new();

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("transaction")]
    public bool? Transaction { get; set; }

    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("type")]
    public MonitorType.Enum Type { get; set; }
}
