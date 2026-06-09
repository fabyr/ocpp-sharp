using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "FirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class FirmwareStatusNotificationRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="FirmwareStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public FirmwareStatus.Enum Status { get; set; }
}
