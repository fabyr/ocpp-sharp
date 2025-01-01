using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ClearChargingProfile
{
    public static readonly ClearChargingProfile Empty = new();

    [JsonProperty("evseId")]
    public long? EvseId { get; set; }

    [JsonProperty("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum? ChargingProfilePurpose { get; set; }

    [JsonProperty("stackLevel")]
    public int? StackLevel { get; set; }
}
