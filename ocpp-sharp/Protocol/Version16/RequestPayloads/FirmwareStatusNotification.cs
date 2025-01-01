using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "FirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class FirmwareStatusNotificationRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="FirmwareStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public FirmwareStatus.Enum Status { get; set; }
}
