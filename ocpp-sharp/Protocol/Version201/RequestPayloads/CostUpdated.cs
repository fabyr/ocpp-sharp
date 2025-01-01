using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CostUpdated", OcppMessageAttribute.Direction.CentralToPoint)]
public class CostUpdatedRequest : RequestPayload
{
    [JsonProperty("totalCost")]
    public decimal TotalCost { get; set; }

    [JsonProperty("transactionId")]
    public CiString TransactionId { get; set; }
}
