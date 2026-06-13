using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "PublishFirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class PublishFirmwareStatusNotificationRequest : RequestPayload
{
    [JsonPropertyName("status")]
    public PublishFirmwareStatusType.Enum Status { get; set; }

    [JsonPropertyName("location")]
    public string[]? Location { get; set; }

    [JsonPropertyName("requestId")]
    public long? RequestId { get; set; }
}
