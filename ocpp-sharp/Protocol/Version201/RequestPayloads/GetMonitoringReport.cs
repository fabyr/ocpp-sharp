using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetMonitoringReport", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetMonitoringReportRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    /// <summary>
    /// Array length must not exceed 3.
    /// </summary>
    [JsonProperty("monitoringCriteria")]
    public MonitoringCriterionType.Enum[]? MonitoringCriteria { get; set; }

    [JsonProperty("componentVariable")]
    public ComponentVariable[]? ComponentVariable { get; set; }
}
