using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Authorize", OcppMessageAttribute.Direction.PointToCentral)]
public class AuthorizeRequest : RequestPayload
{
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    [JsonPropertyName("idToken")]
    public IdToken IdToken { get; set; } = IdToken.Empty;

    [JsonPropertyName("iso15118CertificateHashData")]
    public OCSPRequestData Iso15118CertificateHashData { get; set; } = OCSPRequestData.Empty;
}
