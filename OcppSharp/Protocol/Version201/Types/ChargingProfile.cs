using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingProfile
{
    public static readonly ChargingProfile Empty = new();

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("stackLevel")]
    public int StackLevel { get; set; }

    [JsonPropertyName("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum ChargingProfilePurpose { get; set; }

    [JsonPropertyName("chargingProfileKind")]
    public ChargingProfileKindType.Enum ChargingProfileKind { get; set; }

    [JsonPropertyName("recurrencyKind")]
    public RecurrencyKindType.Enum RecurrencyKind { get; set; }
}
