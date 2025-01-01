using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "TriggerMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class TriggerMessageRequest : RequestPayload
{
    [JsonProperty("requestedMessage")]
    public MessageTriggerType.Enum RequestedMessage { get; set; }

    [JsonProperty("evse")]
    public EVSE? Evse { get; set; }
}
