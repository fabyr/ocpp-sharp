using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ClearChargingProfile", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearChargingProfileResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ClearChargingProfileStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public ClearChargingProfileStatus.Enum Status { get; set; }
}
