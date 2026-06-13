using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "BootNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class BootNotificationRequest : RequestPayload
{
    [JsonPropertyName("reason")]
    public BootReasonType.Enum Reason { get; set; }

    [JsonPropertyName("chargingStation")]
    public ChargingStation ChargingStation { get; set; } = ChargingStation.Empty;
}
