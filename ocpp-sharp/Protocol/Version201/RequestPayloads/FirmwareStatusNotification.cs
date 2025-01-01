using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "FirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class FirmwareStatusNotificationRequest : RequestPayload
{
    [JsonProperty("status")]
    public FirmwareStatusType.Enum Status { get; set; }

    [JsonProperty("requestId")]
    public long RequestId { get; set; }
}
