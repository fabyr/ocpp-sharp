using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetCompositeSchedule", OcppMessageAttribute.Direction.PointToCentral)]
public class GetCompositeScheduleResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonPropertyName("schedule")]
    public CompositeSchedule Schedule { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
