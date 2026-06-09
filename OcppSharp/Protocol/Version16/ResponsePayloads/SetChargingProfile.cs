using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "SetChargingProfile", OcppMessageAttribute.Direction.PointToCentral)]
public class SetChargingProfileResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ChargingProfileStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public ChargingProfileStatus.Enum Status { get; set; }
}
