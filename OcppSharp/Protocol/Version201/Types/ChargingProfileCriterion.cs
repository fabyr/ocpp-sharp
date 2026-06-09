using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingProfileCriterion
{
    public static readonly ChargingProfileCriterion Empty = new();

    [JsonPropertyName("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum? ChargingProfilePurpose { get; set; }

    [JsonPropertyName("stackLevel")]
    public int? StackLevel { get; set; }

    [JsonPropertyName("chargingProfileId")]
    public int[]? ChargingProfileId { get; set; }

    /// <summary>
    /// Array length must not exceed 4.
    /// </summary>
    [JsonPropertyName("chargingLimitSource")]
    public ChargingLimitSourceType.Enum[]? ChargingLimitSource { get; set; }
}
