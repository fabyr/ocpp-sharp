using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetTransactionStatus", OcppMessageAttribute.Direction.PointToCentral)]
public class GetTransactionStatusResponse : ResponsePayload
{
    [JsonProperty("ongoingIndicator")]
    public bool? OngoingIndicator { get; set; }

    [JsonProperty("messagesInQueue")]
    public bool MessagesInQueue { get; set; }
}
