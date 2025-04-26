using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetTransactionStatus", OcppMessageAttribute.Direction.PointToCentral)]
public class GetTransactionStatusResponse : ResponsePayload
{
    [JsonPropertyName("ongoingIndicator")]
    public bool? OngoingIndicator { get; set; }

    [JsonPropertyName("messagesInQueue")]
    public bool MessagesInQueue { get; set; }
}
