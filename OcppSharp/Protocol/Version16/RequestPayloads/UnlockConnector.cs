using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "UnlockConnector", OcppMessageAttribute.Direction.CentralToPoint)]
public class UnlockConnectorRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public ulong ConnectorId { get; set; }
}
