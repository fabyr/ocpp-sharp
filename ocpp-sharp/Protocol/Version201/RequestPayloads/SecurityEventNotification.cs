using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SecurityEventNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class SecurityEventNotificationRequest : RequestPayload
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("techInfo")]
    public string? TechInfo { get; set; }
}
