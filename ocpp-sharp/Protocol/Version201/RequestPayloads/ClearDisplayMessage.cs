using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearDisplayMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearDisplayMessageRequest : RequestPayload
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
