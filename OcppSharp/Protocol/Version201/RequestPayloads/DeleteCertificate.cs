using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "DeleteCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
public class DeleteCertificateRequest : RequestPayload
{
    [JsonPropertyName("certificateHashData")]
    public CertificateHashData CertificateHashData { get; set; } = CertificateHashData.Empty;
}
