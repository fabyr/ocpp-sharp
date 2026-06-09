using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetCompositeSchedule", OcppMessageAttribute.Direction.PointToCentral)]
public class GetCompositeScheduleResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="GetCompositeScheduleStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public GetCompositeScheduleStatus.Enum Status { get; set; }

    [JsonPropertyName("connectorId")]
    public long? ConnectorId { get; set; }

    [JsonPropertyName("scheduleStart")]
    public DateTime? ScheduleStart { get; set; }

    [JsonPropertyName("chargingSchedule")]
    public ChargingSchedule? ChargingSchedule { get; set; }
}
