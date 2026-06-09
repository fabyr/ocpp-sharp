using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Authorize", OcppMessageAttribute.Direction.PointToCentral)]
public class AuthorizeRequest : RequestPayload
{
    [JsonPropertyName("idTag")]
    public CiString IdTag { get; set; } = string.Empty;
}
