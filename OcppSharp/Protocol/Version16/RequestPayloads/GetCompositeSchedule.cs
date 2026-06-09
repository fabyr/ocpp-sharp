using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetCompositeSchedule", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetCompositeScheduleRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public long ConnectorId { get; set; }
    [JsonPropertyName("duration")]
    public long Duration { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingRateUnitType"/>
    /// </summary>
    [JsonPropertyName("chargingRateUnit")]
    public ChargingRateUnitType.Enum? ChargingRateUnit { get; set; }
}
