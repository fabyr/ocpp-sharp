using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "SetChargingProfile", OcppMessageAttribute.Direction.PointToCentral)]
public class SetChargingProfileResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ChargingProfileStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public ChargingProfileStatus.Enum Status { get; set; }
}
