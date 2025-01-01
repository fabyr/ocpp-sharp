using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CertificateSigned", OcppMessageAttribute.Direction.CentralToPoint)]
public class CertificateSignedRequest : RequestPayload
{
    [JsonProperty("certificateChain")]
    public string CertificateChain { get; set; } = string.Empty;

    [JsonProperty("certificateType")]
    public CertificateSigningUseType.Enum CertificateType { get; set; }
}
