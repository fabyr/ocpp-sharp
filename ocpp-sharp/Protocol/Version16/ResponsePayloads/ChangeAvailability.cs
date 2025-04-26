using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ChangeAvailability", OcppMessageAttribute.Direction.PointToCentral)]
public class ChangeAvailabilityResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="AvailabilityStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public AvailabilityStatus.Enum Status { get; set; }
}
