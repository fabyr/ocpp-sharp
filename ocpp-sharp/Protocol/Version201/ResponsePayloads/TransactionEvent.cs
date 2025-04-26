using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "TransactionEvent", OcppMessageAttribute.Direction.CentralToPoint)]
public class TransactionEventResponse : ResponsePayload
{
    [JsonPropertyName("totalCost")]
    public decimal? TotalCost { get; set; }

    [JsonPropertyName("chargingPriority")]
    public int? ChargingPriority { get; set; }

    [JsonPropertyName("idTokenInfo")]
    public IdTokenInfo? IdTokenInfo { get; set; }

    [JsonPropertyName("updatedPersonalMessage")]
    public MessageContent? UpdatedPersonalMessage { get; set; }
}
