using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DiagnosticsStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class DiagnosticsStatusNotificationRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="DiagnosticsStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public DiagnosticsStatus.Enum Status { get; set; }
}
