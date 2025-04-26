using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetCertificateStatus", OcppMessageAttribute.Direction.PointToCentral)]
public class GetCertificateStatusRequest : RequestPayload
{
    [JsonPropertyName("ocspRequestData")]
    public OCSPRequestData OcspRequestData { get; set; } = OCSPRequestData.Empty;
}
