using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ReserveNow", OcppMessageAttribute.Direction.PointToCentral)]
public class ReserveNowResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ReservationStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public ReservationStatus.Enum Status { get; set; }
}
