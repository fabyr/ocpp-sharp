using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetMonitoringData
{
    public static readonly SetMonitoringData Empty = new();

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("transaction")]
    public bool? Transaction { get; set; }

    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("type")]
    public MonitorType.Enum Type { get; set; }
}
