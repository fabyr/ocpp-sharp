using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "LogStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class LogStatusNotificationRequest : RequestPayload
{
    [JsonPropertyName("status")]
    public UploadLogStatusType.Enum Status { get; set; }

    [JsonPropertyName("requestId")]
    public long? RequestId { get; set; }
}
