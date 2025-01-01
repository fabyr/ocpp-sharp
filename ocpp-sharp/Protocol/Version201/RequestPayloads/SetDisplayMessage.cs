using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetDisplayMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetDisplayMessageRequest : RequestPayload
{
    [JsonProperty("message")]
    public MessageInfo Message { get; set; }
}
