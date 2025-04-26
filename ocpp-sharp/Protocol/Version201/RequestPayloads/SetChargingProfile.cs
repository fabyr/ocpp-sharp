using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetChargingProfileRequest : RequestPayload
{
    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("chargingProfile")]
    public ChargingProfile ChargingProfile { get; set; }
}
