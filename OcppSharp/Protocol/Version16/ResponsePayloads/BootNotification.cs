using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "BootNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class BootNotificationResponse : ResponsePayload
{
    [JsonPropertyName("currentTime")]
    public DateTime CurrentTime { get; set; }

    [JsonPropertyName("interval")]
    public long Interval { get; set; }

    /// <summary>
    /// Valid values in <see cref="RegistrationStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public RegistrationStatus.Enum Status { get; set; }
}
