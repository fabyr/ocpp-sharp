using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ChangeAvailability", OcppMessageAttribute.Direction.PointToCentral)]
public class ChangeAvailabilityResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="AvailabilityStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public AvailabilityStatus.Enum Status { get; set; }
}
