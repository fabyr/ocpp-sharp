using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyChargingLimit", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyChargingLimitRequest : RequestPayload
{
    [JsonProperty("evseId")]
    public long? EvseId { get; set; }

    [JsonProperty("chargingLimit")]
    public ChargingLimit ChargingLimit { get; set; } = ChargingLimit.Empty;

    [JsonProperty("chargingSchedule")]
    public ChargingSchedule[]? ChargingSchedule { get; set; }
}
