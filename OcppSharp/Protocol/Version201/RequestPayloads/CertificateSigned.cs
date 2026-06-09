using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CertificateSigned", OcppMessageAttribute.Direction.CentralToPoint)]
public class CertificateSignedRequest : RequestPayload
{
    [JsonPropertyName("certificateChain")]
    public string CertificateChain { get; set; } = string.Empty;

    [JsonPropertyName("certificateType")]
    public CertificateSigningUseType.Enum CertificateType { get; set; }
}
