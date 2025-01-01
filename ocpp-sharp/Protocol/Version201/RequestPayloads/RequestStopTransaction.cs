using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "RequestStopTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RequestStopTransactionRequest : RequestPayload
{
    [JsonProperty("transactionId")]
    public CiString TransactionId { get; set; }
}
