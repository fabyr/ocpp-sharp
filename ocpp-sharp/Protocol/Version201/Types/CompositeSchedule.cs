using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct CompositeSchedule
{
    public static readonly CompositeSchedule Empty = new();

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("duration")]
    public int Duration { get; set; }

    [JsonProperty("scheduleStart")]
    public DateTime ScheduleStart { get; set; }

    [JsonProperty("chargingRateUnit")]
    public ChargingRateUnitType.Enum ChargingRateUnit { get; set; }

    /// <summary>
    /// Must be at least one.
    /// </summary>
    [JsonProperty("chargingSchedulePeriod")]
    public ChargingSchedulePeriod[] ChargingSchedulePeriod { get; set; }
}
