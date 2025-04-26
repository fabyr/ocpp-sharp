using OcppSharp.Protocol.Version16.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "RemoteStartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RemoteStartTransactionRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public long? ConnectorId { get; set; }

    [JsonPropertyName("idTag")]
    public CiString IdTag { get; set; } = string.Empty;

    [JsonPropertyName("chargingProfile")]
    public ChargingProfile? ChargingProfile { get; set; }
}
