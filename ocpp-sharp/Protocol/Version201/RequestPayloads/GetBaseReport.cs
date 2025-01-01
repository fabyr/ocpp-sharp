using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetBaseReport", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetBaseReportRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("reportBase")]
    public ReportBaseType.Enum ReportBase { get; set; }
}
