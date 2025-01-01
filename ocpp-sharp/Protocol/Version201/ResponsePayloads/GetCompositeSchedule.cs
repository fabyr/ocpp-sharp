using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetCompositeSchedule", OcppMessageAttribute.Direction.PointToCentral)]
public class GetCompositeScheduleResponse : ResponsePayload
{
    [JsonProperty("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonProperty("schedule")]
    public CompositeSchedule Schedule { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
