using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetInstalledCertificateIds", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetInstalledCertificateIdsRequest : RequestPayload
{
    [JsonProperty("certificateType")]
    public GetCertificateIdUseType.Enum[]? CertificateType { get; set; }
}
