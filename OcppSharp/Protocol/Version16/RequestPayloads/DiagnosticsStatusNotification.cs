using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DiagnosticsStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class DiagnosticsStatusNotificationRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="DiagnosticsStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public DiagnosticsStatus.Enum Status { get; set; }
}
