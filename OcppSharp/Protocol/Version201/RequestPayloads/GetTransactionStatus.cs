using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetTransactionStatus", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetTransactionStatusRequest : RequestPayload
{
    [JsonPropertyName("transactionId")]
    public CiString? TransactionId { get; set; }
}
