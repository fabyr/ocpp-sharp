using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEVChargingNeeds", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyEVChargingNeedsRequest : RequestPayload
{
    [JsonPropertyName("maxScheduleTuples")]
    public int? MaxScheduleTuples { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("chargingNeeds")]
    public ChargingNeeds ChargingNeeds { get; set; }
}
