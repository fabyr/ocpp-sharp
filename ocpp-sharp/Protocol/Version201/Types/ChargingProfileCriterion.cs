using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingProfileCriterion
{
    public static readonly ChargingProfileCriterion Empty = new();

    [JsonProperty("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum? ChargingProfilePurpose { get; set; }

    [JsonProperty("stackLevel")]
    public int? StackLevel { get; set; }

    [JsonProperty("chargingProfileId")]
    public int[]? ChargingProfileId { get; set; }

    /// <summary>
    /// Array length must not exceed 4.
    /// </summary>
    [JsonProperty("chargingLimitSource")]
    public ChargingLimitSourceType.Enum[]? ChargingLimitSource { get; set; }
}
