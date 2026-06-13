using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetInstalledCertificateIds", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetInstalledCertificateIdsRequest : RequestPayload
{
    [JsonPropertyName("certificateType")]
    public GetCertificateIdUseType.Enum[]? CertificateType { get; set; }
}
