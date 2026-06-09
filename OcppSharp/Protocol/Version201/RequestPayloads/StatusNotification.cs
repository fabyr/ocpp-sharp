using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "StatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class StatusNotificationRequest : RequestPayload
{
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("connectorStatus")]
    public ConnectorStatusType.Enum ConnectorStatus { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("connectorId")]
    public long ConnectorId { get; set; }

}
