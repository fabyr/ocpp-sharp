using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Authorize", OcppMessageAttribute.Direction.CentralToPoint)]
public class AuthorizeResponse : ResponsePayload
{
    [JsonProperty("certificateStatus")]
    public AuthorizeCertificateStatusType.Enum? CertificateStatus { get; set; }

    [JsonProperty("idTokenInfo")]
    public IdTokenInfo IdTokenInfo { get; set; } = IdTokenInfo.Empty;
}
