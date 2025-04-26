using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "InstallCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
public class InstallCertificateRequest : RequestPayload
{
    [JsonPropertyName("certificateType")]
    public InstallCertificateUseType.Enum CertificateType { get; set; }

    [JsonPropertyName("certificate")]
    public string Certificate { get; set; } = string.Empty;
}
