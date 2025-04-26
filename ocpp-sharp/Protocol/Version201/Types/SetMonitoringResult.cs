using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetMonitoringResult
{
    public static readonly SetMonitoringResult Empty = new();

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("status")]
    public SetMonitoringStatusType.Enum Status { get; set; }

    [JsonPropertyName("type")]
    public MonitorType.Enum Type { get; set; }
}
