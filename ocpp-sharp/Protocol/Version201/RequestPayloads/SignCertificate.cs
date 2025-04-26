using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SignCertificate", OcppMessageAttribute.Direction.PointToCentral)]
public class SignCertificateRequest : RequestPayload
{
    [JsonPropertyName("csr")]
    public string Csr { get; set; } = string.Empty;

    [JsonPropertyName("certificateType")]
    public CertificateSigningUseType.Enum? CertificateType { get; set; }
}
