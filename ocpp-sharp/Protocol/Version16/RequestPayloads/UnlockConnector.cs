using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "UnlockConnector", OcppMessageAttribute.Direction.CentralToPoint)]
public class UnlockConnectorRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public ulong ConnectorId { get; set; }
}
