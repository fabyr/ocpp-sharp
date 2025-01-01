using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetBaseReport", OcppMessageAttribute.Direction.PointToCentral)]
public class GetBaseReportResponse : ResponsePayload
{
    [JsonProperty("status")]
    public GenericDeviceModelStatusType.Enum Status { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
