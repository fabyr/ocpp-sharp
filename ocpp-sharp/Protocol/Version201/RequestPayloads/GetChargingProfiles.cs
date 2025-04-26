using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetChargingProfiles", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetChargingProfilesRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("chargingProfile")]
    public ChargingProfileCriterion ChargingProfile { get; set; } = ChargingProfileCriterion.Empty;
}
