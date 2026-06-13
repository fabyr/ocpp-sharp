using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types;

public struct ClearChargingProfile
{
    public static readonly ClearChargingProfile Empty = new();

    [JsonPropertyName("evseId")]
    public long? EvseId { get; set; }

    [JsonPropertyName("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum? ChargingProfilePurpose { get; set; }

    [JsonPropertyName("stackLevel")]
    public int? StackLevel { get; set; }
}
