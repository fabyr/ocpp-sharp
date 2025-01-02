using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct ChargingProfile
{
    public static readonly ChargingProfile Empty = new();

    [JsonProperty("chargingProfileId")]
    public long ChargingProfileId { get; set; }

    [JsonProperty("transactionId")]
    public long? TransactionId { get; set; }

    [JsonProperty("stackLevel")]
    public ulong StackLevel { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingProfilePurposeType"/>
    /// </summary>
    [JsonProperty("chargingProfilePurpose")]
    public ChargingProfilePurposeType.Enum ChargingProfilePurpose { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingProfileKindType"/>
    /// </summary>
    [JsonProperty("chargingProfileKind")]
    public ChargingProfileKindType.Enum ChargingProfileKind { get; set; }

    /// <summary>
    /// Valid values in <see cref="RecurrencyKindType"/>
    /// </summary>
    [JsonProperty("recurrencyKind")]
    public RecurrencyKindType.Enum? RecurrencyKind { get; set; }

    [JsonProperty("validFrom")]
    public DateTime? ValidFrom { get; set; }

    [JsonProperty("validTo")]
    public DateTime? ValidTo { get; set; }

    [JsonProperty("chargingSchedule")]
    public ChargingSchedule ChargingSchedule { get; set; }
}
