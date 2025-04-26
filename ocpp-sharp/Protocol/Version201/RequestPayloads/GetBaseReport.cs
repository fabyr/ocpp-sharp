using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetBaseReport", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetBaseReportRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("reportBase")]
    public ReportBaseType.Enum ReportBase { get; set; }
}
