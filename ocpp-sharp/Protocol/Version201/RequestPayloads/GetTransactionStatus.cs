using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetTransactionStatus", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetTransactionStatusRequest : RequestPayload
{
    [JsonProperty("transactionId")]
    public CiString? TransactionId { get; set; }
}
