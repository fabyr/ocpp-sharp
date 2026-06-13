using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SignCertificate", OcppMessageAttribute.Direction.PointToCentral)]
public class SignCertificateRequest : RequestPayload
{
    [JsonPropertyName("csr")]
    public string Csr { get; set; } = string.Empty;

    [JsonPropertyName("certificateType")]
    public CertificateSigningUseType.Enum? CertificateType { get; set; }
}
