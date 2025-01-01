using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEVChargingSchedule", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyEVChargingScheduleRequest : RequestPayload
{
    [JsonProperty("timeBase")]
    public DateTime TimeBase { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("chargingSchedule")]
    public ChargingSchedule ChargingSchedule { get; set; }
}
