using OcppSharp.Protocol.Version16.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "Authorize", OcppMessageAttribute.Direction.CentralToPoint)]
public class AuthorizeResponse : ResponsePayload
{
    [JsonPropertyName("idTagInfo")]
    public IdTagInfo IdTagInfo { get; set; } = IdTagInfo.Empty;
}
