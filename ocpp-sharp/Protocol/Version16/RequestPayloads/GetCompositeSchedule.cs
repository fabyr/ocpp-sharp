using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetCompositeSchedule", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetCompositeScheduleRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public long ConnectorId { get; set; }
    [JsonProperty("duration")]
    public long Duration { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingRateUnitType"/>
    /// </summary>
    [JsonProperty("chargingRateUnit")]
    public ChargingRateUnitType.Enum? ChargingRateUnit { get; set; }
}
