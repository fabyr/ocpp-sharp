using Newtonsoft.Json;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetMonitoringBase", OcppMessageAttribute.Direction.PointToCentral)]
public class SetMonitoringBaseResponse : ResponsePayload
{
    [JsonProperty("status")]
    public GenericDeviceModelStatusType.Enum Status { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
