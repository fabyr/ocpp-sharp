using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyChargingLimit", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyChargingLimitRequest : RequestPayload
{
    [JsonPropertyName("evseId")]
    public long? EvseId { get; set; }

    [JsonPropertyName("chargingLimit")]
    public ChargingLimit ChargingLimit { get; set; } = ChargingLimit.Empty;

    [JsonPropertyName("chargingSchedule")]
    public ChargingSchedule[]? ChargingSchedule { get; set; }
}
