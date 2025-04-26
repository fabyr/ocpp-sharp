using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ReserveNow", OcppMessageAttribute.Direction.PointToCentral)]
public class ReserveNowResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ReservationStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public ReservationStatus.Enum Status { get; set; }
}
