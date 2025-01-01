using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "InstallCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
public class InstallCertificateRequest : RequestPayload
{
    [JsonProperty("certificateType")]
    public InstallCertificateUseType.Enum CertificateType { get; set; }

    [JsonProperty("certificate")]
    public string Certificate { get; set; } = string.Empty;
}
