using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UnlockConnector", OcppMessageAttribute.Direction.CentralToPoint)]
public class UnlockConnectorRequest : RequestPayload
{
    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("connectorId")]
    public long ConnectorId { get; set; }
}
