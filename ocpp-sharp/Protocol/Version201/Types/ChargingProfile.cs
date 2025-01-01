using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingProfile
{
    public static readonly ChargingProfile Empty = new();

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("stackLevel")]
    public int StackLevel { get; set; }

    [JsonProperty("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum ChargingProfilePurpose { get; set; }

    [JsonProperty("chargingProfileKind")]
    public ChargingProfileKindType.Enum ChargingProfileKind { get; set; }

    [JsonProperty("recurrencyKind")]
    public RecurrencyKindType.Enum RecurrencyKind { get; set; }
}
