using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "RemoteStopTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RemoteStopTransactionRequest : RequestPayload
{
    [JsonProperty("transactionId")]
    public long TransactionId { get; set; }
}
