using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint)]
public class ReserveNowRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public ulong ConnectorId { get; set; }

    [JsonProperty("expiryDate")]
    public DateTime ExpiryDate { get; set; }

    [JsonProperty("idTag")]
    public CiString IdTag { get; set; } = string.Empty;

    [JsonProperty("parentIdTag")]
    public CiString? ParentIdTag { get; set; }

    [JsonProperty("reservationId")]
    public long ReservationId { get; set; }
}
