using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UnlockConnector", OcppMessageAttribute.Direction.CentralToPoint)]
public class UnlockConnectorRequest : RequestPayload
{
    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("connectorId")]
    public long ConnectorId { get; set; }
}
