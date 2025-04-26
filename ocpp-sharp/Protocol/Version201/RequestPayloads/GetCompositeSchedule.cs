using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetCompositeSchedule", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetCompositeScheduleRequest : RequestPayload
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("chargingRateUnit")]
    public ChargingRateUnitType.Enum? ChargingRateUnit { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }
}
