using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetCompositeSchedule", OcppMessageAttribute.Direction.PointToCentral)]
public class GetCompositeScheduleResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="GetCompositeScheduleStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public GetCompositeScheduleStatus.Enum Status { get; set; }

    [JsonProperty("connectorId")]
    public long? ConnectorId { get; set; }

    [JsonProperty("scheduleStart")]
    public DateTime? ScheduleStart { get; set; }

    [JsonProperty("chargingSchedule")]
    public ChargingSchedule? ChargingSchedule { get; set; }
}
