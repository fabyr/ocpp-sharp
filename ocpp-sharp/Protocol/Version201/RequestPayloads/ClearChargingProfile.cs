using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearChargingProfileRequest : RequestPayload
{
    [JsonPropertyName("chargingProfileId")]
    public long? ChargingProfileId { get; set; }

    [JsonPropertyName("chargingProfileCriteria")]
    public ClearChargingProfile? ChargingProfileCriteria { get; set; }
}
