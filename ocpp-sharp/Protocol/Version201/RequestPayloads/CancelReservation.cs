using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CancelReservation", OcppMessageAttribute.Direction.CentralToPoint)]
public class CancelReservationRequest : RequestPayload
{
    [JsonPropertyName("reservationId")]
    public long ReservationId { get; set; }
}
