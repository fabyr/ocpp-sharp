using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "TriggerMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class TriggerMessageRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="MessageTrigger"/>
    /// </summary>
    [JsonPropertyName("requestedMessage")]
    public MessageTrigger.Enum RequestedMessage { get; set; }

    [JsonPropertyName("connectorId")]
    public ulong? ConnectorId { get; set; }
}
