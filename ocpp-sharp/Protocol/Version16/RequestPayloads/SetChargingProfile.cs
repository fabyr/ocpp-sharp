using OcppSharp.Protocol.Version16.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "SetChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetChargingProfileRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public long ConnectorId { get; set; }

    [JsonPropertyName("csChargingProfiles")]
    public ChargingProfile CsChargingProfiles { get; set; } = ChargingProfile.Empty;
}
