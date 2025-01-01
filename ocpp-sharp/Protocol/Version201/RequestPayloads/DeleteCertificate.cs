using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "DeleteCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
public class DeleteCertificateRequest : RequestPayload
{
    [JsonProperty("certificateHashData")]
    public CertificateHashData CertificateHashData { get; set; } = CertificateHashData.Empty;
}
