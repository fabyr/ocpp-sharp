using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetDisplayMessages", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetDisplayMessagesRequest : RequestPayload
{
    [JsonProperty("id")]
    public long[]? Id { get; set; }

    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("priority")]
    public MessagePriorityType.Enum Priority { get; set; }

    [JsonProperty("state")]
    public MessageStateType.Enum State { get; set; }
}
