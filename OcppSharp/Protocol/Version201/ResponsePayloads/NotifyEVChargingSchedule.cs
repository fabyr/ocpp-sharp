using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "NotifyEVChargingSchedule", OcppMessageAttribute.Direction.CentralToPoint)]
public class NotifyEVChargingScheduleResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
