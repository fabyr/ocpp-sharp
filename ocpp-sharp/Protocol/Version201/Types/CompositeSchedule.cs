using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct CompositeSchedule
{
    public static readonly CompositeSchedule Empty = new();

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("scheduleStart")]
    public DateTime ScheduleStart { get; set; }

    [JsonPropertyName("chargingRateUnit")]
    public ChargingRateUnitType.Enum ChargingRateUnit { get; set; }

    /// <summary>
    /// Must be at least one.
    /// </summary>
    [JsonPropertyName("chargingSchedulePeriod")]
    public ChargingSchedulePeriod[] ChargingSchedulePeriod { get; set; }
}
