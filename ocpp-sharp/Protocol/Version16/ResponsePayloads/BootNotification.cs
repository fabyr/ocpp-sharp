using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "BootNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class BootNotificationResponse : ResponsePayload
{
    [JsonProperty("currentTime")]
    public DateTime CurrentTime { get; set; }

    [JsonProperty("interval")]
    public long Interval { get; set; }

    /// <summary>
    /// Valid values in <see cref="RegistrationStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public RegistrationStatus.Enum Status { get; set; }
}
