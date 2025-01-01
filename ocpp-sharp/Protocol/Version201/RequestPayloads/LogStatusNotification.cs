using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "LogStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class LogStatusNotificationRequest : RequestPayload
{
    [JsonProperty("status")]
    public UploadLogStatusType.Enum Status { get; set; }

    [JsonProperty("requestId")]
    public long? RequestId { get; set; }
}
