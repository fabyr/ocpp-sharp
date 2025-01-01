using OcppSharp.Protocol.Version16.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "RemoteStartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RemoteStartTransactionRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public long? ConnectorId { get; set; }

    [JsonProperty("idTag")]
    public CiString IdTag { get; set; } = string.Empty;

    [JsonProperty("chargingProfile")]
    public ChargingProfile? ChargingProfile { get; set; }
}
