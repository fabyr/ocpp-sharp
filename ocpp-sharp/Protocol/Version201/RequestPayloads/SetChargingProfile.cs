using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetChargingProfileRequest : RequestPayload
{
    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("chargingProfile")]
    public ChargingProfile ChargingProfile { get; set; }
}
