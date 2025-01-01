using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class StatusNotificationRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public ulong ConnectorId { get; set; }

    [JsonProperty("errorCode")]
    public CiString ErrorCode { get; set; } = string.Empty;

    [JsonProperty("info")]
    public CiString? Info { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargePointStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public ChargePointStatus.Enum Status { get; set; }

    [JsonProperty("timestamp")]
    public DateTime? Timestamp { get; set; }
}
