using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetCompositeSchedule", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetCompositeScheduleRequest : RequestPayload
{
    [JsonProperty("duration")]
    public int Duration { get; set; }

    [JsonProperty("chargingRateUnit")]
    public ChargingRateUnitType.Enum? ChargingRateUnit { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }
}
