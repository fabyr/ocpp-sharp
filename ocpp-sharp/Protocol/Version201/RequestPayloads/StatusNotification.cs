using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "StatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class StatusNotificationRequest : RequestPayload
{
    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("connectorStatus")]
    public ConnectorStatusType.Enum ConnectorStatus { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("connectorId")]
    public long ConnectorId { get; set; }

}
