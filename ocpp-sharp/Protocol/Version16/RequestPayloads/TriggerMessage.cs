using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "TriggerMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class TriggerMessageRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="MessageTrigger"/>
    /// </summary>
    [JsonProperty("requestedMessage")]
    public MessageTrigger.Enum RequestedMessage { get; set; }

    [JsonProperty("connectorId")]
    public ulong? ConnectorId { get; set; }
}
