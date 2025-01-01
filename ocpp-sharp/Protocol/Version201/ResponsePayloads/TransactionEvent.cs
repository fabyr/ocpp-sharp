using Newtonsoft.Json;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "TransactionEvent", OcppMessageAttribute.Direction.CentralToPoint)]
public class TransactionEventResponse : ResponsePayload
{
    [JsonProperty("totalCost")]
    public decimal? TotalCost { get; set; }

    [JsonProperty("chargingPriority")]
    public int? ChargingPriority { get; set; }

    [JsonProperty("idTokenInfo")]
    public IdTokenInfo? IdTokenInfo { get; set; }

    [JsonProperty("updatedPersonalMessage")]
    public MessageContent? UpdatedPersonalMessage { get; set; }
}
