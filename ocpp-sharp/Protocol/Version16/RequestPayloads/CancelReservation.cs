using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "CancelReservation", OcppMessageAttribute.Direction.CentralToPoint)]
public class CancelReservationRequest : RequestPayload
{
    [JsonProperty("reservationId")]
    public long ReservationId { get; set; }
}
