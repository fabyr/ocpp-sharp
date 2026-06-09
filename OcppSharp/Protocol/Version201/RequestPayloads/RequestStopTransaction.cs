using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "RequestStopTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RequestStopTransactionRequest : RequestPayload
{
    [JsonPropertyName("transactionId")]
    public CiString TransactionId { get; set; }
}
