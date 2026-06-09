using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint)]
public class ReserveNowRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public ulong ConnectorId { get; set; }

    [JsonPropertyName("expiryDate")]
    public DateTime ExpiryDate { get; set; }

    [JsonPropertyName("idTag")]
    public CiString IdTag { get; set; } = string.Empty;

    [JsonPropertyName("parentIdTag")]
    public CiString? ParentIdTag { get; set; }

    [JsonPropertyName("reservationId")]
    public long ReservationId { get; set; }
}
