using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetMonitoringReport", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetMonitoringReportRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    /// <summary>
    /// Array length must not exceed 3.
    /// </summary>
    [JsonPropertyName("monitoringCriteria")]
    public MonitoringCriterionType.Enum[]? MonitoringCriteria { get; set; }

    [JsonPropertyName("componentVariable")]
    public ComponentVariable[]? ComponentVariable { get; set; }
}
