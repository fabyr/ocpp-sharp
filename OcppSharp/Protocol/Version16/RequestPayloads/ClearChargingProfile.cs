using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ClearChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearChargingProfileRequest : RequestPayload
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }
    [JsonPropertyName("connectorId")]
    public long? ConnectorId { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingProfilePurposeType"/>
    /// </summary>
    [JsonPropertyName("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum? ChargingProfilePurpose { get; set; }

    [JsonPropertyName("stackLevel")]
    public long? StackLevel { get; set; }
}
