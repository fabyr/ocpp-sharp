using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "RemoteStopTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RemoteStopTransactionRequest : RequestPayload
{
    [JsonPropertyName("transactionId")]
    public long TransactionId { get; set; }
}
