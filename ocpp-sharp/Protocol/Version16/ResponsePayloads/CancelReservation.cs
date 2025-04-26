using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "CancelReservation", OcppMessageAttribute.Direction.PointToCentral)]
public class CancelReservationResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="CancelReservationStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public CancelReservationStatus.Enum Status { get; set; }
}
