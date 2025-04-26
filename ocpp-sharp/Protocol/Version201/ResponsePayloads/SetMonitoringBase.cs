using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetMonitoringBase", OcppMessageAttribute.Direction.PointToCentral)]
public class SetMonitoringBaseResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GenericDeviceModelStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
