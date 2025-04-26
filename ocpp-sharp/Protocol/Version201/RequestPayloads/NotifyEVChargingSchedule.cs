using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEVChargingSchedule", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyEVChargingScheduleRequest : RequestPayload
{
    [JsonPropertyName("timeBase")]
    public DateTime TimeBase { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("chargingSchedule")]
    public ChargingSchedule ChargingSchedule { get; set; }
}
