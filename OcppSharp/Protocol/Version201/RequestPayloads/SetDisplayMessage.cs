using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetDisplayMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetDisplayMessageRequest : RequestPayload
{
    [JsonPropertyName("message")]
    public MessageInfo Message { get; set; }
}
