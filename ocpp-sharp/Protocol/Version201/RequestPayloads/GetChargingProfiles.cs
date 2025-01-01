using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetChargingProfiles", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetChargingProfilesRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("chargingProfile")]
    public ChargingProfileCriterion ChargingProfile { get; set; } = ChargingProfileCriterion.Empty;
}
