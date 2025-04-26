using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ClearMonitoringResult
{
    public static readonly ClearMonitoringResult Empty = new();

    [JsonPropertyName("status")]
    public ClearMonitoringStatusType.Enum Status { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
