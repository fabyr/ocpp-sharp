using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetReport", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetReportRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    /// <summary>
    /// Array length must not exceed 4.
    /// </summary>
    [JsonProperty("componentCriteria")]
    public ComponentCriterionType.Enum[]? ComponentCriteria { get; set; }

    [JsonProperty("componentVariable")]
    public ComponentVariable[]? ComponentVariable { get; set; }
}
