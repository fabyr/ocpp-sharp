using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version16.MessageConstants;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ClearChargingProfile", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearChargingProfileResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ClearChargingProfileStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public ClearChargingProfileStatus.Enum Status { get; set; }
}
