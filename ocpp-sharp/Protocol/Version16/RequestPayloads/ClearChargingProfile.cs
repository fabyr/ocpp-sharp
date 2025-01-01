using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ClearChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearChargingProfileRequest : RequestPayload
{
    [JsonProperty("id")]
    public long? Id { get; set; }
    [JsonProperty("connectorId")]
    public long? ConnectorId { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingProfilePurposeType"/>
    /// </summary>
    [JsonProperty("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum? ChargingProfilePurpose { get; set; }

    [JsonProperty("stackLevel")]
    public long? StackLevel { get; set; }
}
