using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Authorize", OcppMessageAttribute.Direction.PointToCentral)]
public class AuthorizeRequest : RequestPayload
{
    [JsonProperty("certificate")]
    public string? Certificate { get; set; }

    [JsonProperty("idToken")]
    public IdToken IdToken { get; set; } = IdToken.Empty;

    [JsonProperty("iso15118CertificateHashData")]
    public OCSPRequestData Iso15118CertificateHashData { get; set; } = OCSPRequestData.Empty;
}
