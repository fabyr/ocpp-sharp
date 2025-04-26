using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CostUpdated", OcppMessageAttribute.Direction.CentralToPoint)]
public class CostUpdatedRequest : RequestPayload
{
    [JsonPropertyName("totalCost")]
    public decimal TotalCost { get; set; }

    [JsonPropertyName("transactionId")]
    public CiString TransactionId { get; set; }
}
