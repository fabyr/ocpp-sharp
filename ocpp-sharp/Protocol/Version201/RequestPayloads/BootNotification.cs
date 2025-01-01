using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "BootNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class BootNotificationRequest : RequestPayload
{
    [JsonProperty("reason")]
    public BootReasonType.Enum Reason { get; set; }

    [JsonProperty("chargingStation")]
    public ChargingStation ChargingStation { get; set; } = ChargingStation.Empty;
}
