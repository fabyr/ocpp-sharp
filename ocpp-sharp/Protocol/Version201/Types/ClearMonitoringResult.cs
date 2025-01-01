using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ClearMonitoringResult
{
    public static readonly ClearMonitoringResult Empty = new();

    [JsonProperty("status")]
    public ClearMonitoringStatusType.Enum Status { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
