using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class StatusNotificationRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public ulong ConnectorId { get; set; }

    [JsonPropertyName("errorCode")]
    public CiString ErrorCode { get; set; } = string.Empty;

    [JsonPropertyName("info")]
    public CiString? Info { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargePointStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public ChargePointStatus.Enum Status { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }
}
