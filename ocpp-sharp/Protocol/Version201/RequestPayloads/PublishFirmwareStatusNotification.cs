using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "PublishFirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class PublishFirmwareStatusNotificationRequest : RequestPayload
{
    [JsonProperty("status")]
    public PublishFirmwareStatusType.Enum Status { get; set; }

    [JsonProperty("location")]
    public string[]? Location { get; set; }

    [JsonProperty("requestId")]
    public long? RequestId { get; set; }
}
