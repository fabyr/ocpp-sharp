using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetInstalledCertificateIds", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetInstalledCertificateIdsRequest : RequestPayload
{
    [JsonPropertyName("certificateType")]
    public GetCertificateIdUseType.Enum[]? CertificateType { get; set; }
}
