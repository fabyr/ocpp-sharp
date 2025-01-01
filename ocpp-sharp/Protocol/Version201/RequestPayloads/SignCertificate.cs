using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SignCertificate", OcppMessageAttribute.Direction.PointToCentral)]
public class SignCertificateRequest : RequestPayload
{
    [JsonProperty("csr")]
    public string Csr { get; set; } = string.Empty;

    [JsonProperty("certificateType")]
    public CertificateSigningUseType.Enum? CertificateType { get; set; }
}
