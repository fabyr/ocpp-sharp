using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetMonitoringResult
{
    public static readonly SetMonitoringResult Empty = new();

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("status")]
    public SetMonitoringStatusType.Enum Status { get; set; }

    [JsonProperty("type")]
    public MonitorType.Enum Type { get; set; }
}
