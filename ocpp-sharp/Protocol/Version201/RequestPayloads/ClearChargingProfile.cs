using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearChargingProfileRequest : RequestPayload
{
    [JsonProperty("chargingProfileId")]
    public long? ChargingProfileId { get; set; }

    [JsonProperty("chargingProfileCriteria")]
    public ClearChargingProfile? ChargingProfileCriteria { get; set; }
}
