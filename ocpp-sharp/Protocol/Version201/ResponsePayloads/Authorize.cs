using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Authorize", OcppMessageAttribute.Direction.CentralToPoint)]
public class AuthorizeResponse : ResponsePayload
{
    [JsonPropertyName("certificateStatus")]
    public AuthorizeCertificateStatusType.Enum? CertificateStatus { get; set; }

    [JsonPropertyName("idTokenInfo")]
    public IdTokenInfo IdTokenInfo { get; set; } = IdTokenInfo.Empty;
}
