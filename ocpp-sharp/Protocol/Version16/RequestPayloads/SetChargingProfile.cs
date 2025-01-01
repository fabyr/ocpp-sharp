using OcppSharp.Protocol.Version16.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "SetChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetChargingProfileRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public long ConnectorId { get; set; }

    [JsonProperty("csChargingProfiles")]
    public ChargingProfile CsChargingProfiles { get; set; } = ChargingProfile.Empty;
}
