using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SecurityEventNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class SecurityEventNotificationRequest : RequestPayload
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("techInfo")]
    public string? TechInfo { get; set; }
}
