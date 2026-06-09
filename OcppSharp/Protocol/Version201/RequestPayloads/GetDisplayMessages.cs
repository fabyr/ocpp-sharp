using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetDisplayMessages", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetDisplayMessagesRequest : RequestPayload
{
    [JsonPropertyName("id")]
    public long[]? Id { get; set; }

    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("priority")]
    public MessagePriorityType.Enum Priority { get; set; }

    [JsonPropertyName("state")]
    public MessageStateType.Enum State { get; set; }
}
