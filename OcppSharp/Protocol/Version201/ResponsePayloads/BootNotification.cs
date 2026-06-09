using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "BootNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class BootNotificationResponse : ResponsePayload
{
    [JsonPropertyName("currentTime")]
    public DateTime CurrentTime { get; set; }

    [JsonPropertyName("interval")]
    public int Interval { get; set; }

    [JsonPropertyName("status")]
    public RegistrationStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
