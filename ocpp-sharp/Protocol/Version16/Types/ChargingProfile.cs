using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct ChargingProfile
{
    public static readonly ChargingProfile Empty = new();

    [JsonPropertyName("chargingProfileId")]
    public long ChargingProfileId { get; set; }

    [JsonPropertyName("transactionId")]
    public long? TransactionId { get; set; }

    [JsonPropertyName("stackLevel")]
    public ulong StackLevel { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingProfilePurposeType"/>
    /// </summary>
    [JsonPropertyName("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum ChargingProfilePurpose { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingProfileKindType"/>
    /// </summary>
    [JsonPropertyName("chargingProfileKind")]
    public ChargingProfileKindType.Enum ChargingProfileKind { get; set; }

    /// <summary>
    /// Valid values in <see cref="RecurrencyKindType"/>
    /// </summary>
    [JsonPropertyName("recurrencyKind")]
    public RecurrencyKindType.Enum? RecurrencyKind { get; set; }

    [JsonPropertyName("validFrom")]
    public DateTime? ValidFrom { get; set; }

    [JsonPropertyName("validTo")]
    public DateTime? ValidTo { get; set; }

    [JsonPropertyName("chargingSchedule")]
    public ChargingSchedule ChargingSchedule { get; set; }
}
