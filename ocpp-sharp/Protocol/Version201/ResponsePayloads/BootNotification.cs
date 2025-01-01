using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "BootNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class BootNotificationResponse : ResponsePayload
{
    [JsonProperty("currentTime")]
    public DateTime CurrentTime { get; set; }

    [JsonProperty("interval")]
    public int Interval { get; set; }

    [JsonProperty("status")]
    public RegistrationStatusType.Enum Status { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
