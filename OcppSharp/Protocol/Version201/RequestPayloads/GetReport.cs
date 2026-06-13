using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetReport", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetReportRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    /// <summary>
    /// Array length must not exceed 4.
    /// </summary>
    [JsonPropertyName("componentCriteria")]
    public ComponentCriterionType.Enum[]? ComponentCriteria { get; set; }

    [JsonPropertyName("componentVariable")]
    public ComponentVariable[]? ComponentVariable { get; set; }
}
