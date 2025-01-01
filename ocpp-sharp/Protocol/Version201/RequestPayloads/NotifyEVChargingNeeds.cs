using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEVChargingNeeds", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyEVChargingNeedsRequest : RequestPayload
{
    [JsonProperty("maxScheduleTuples")]
    public int? MaxScheduleTuples { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("chargingNeeds")]
    public ChargingNeeds ChargingNeeds { get; set; }
}
