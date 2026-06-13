using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

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
