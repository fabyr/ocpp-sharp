using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "FirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class FirmwareStatusNotificationRequest : RequestPayload
{
    [JsonPropertyName("status")]
    public FirmwareStatusType.Enum Status { get; set; }

    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }
}
