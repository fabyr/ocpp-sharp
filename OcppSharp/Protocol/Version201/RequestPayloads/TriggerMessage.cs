using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "TriggerMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class TriggerMessageRequest : RequestPayload
{
    [JsonPropertyName("requestedMessage")]
    public MessageTriggerType.Enum RequestedMessage { get; set; }

    [JsonPropertyName("evse")]
    public EVSE? Evse { get; set; }
}
