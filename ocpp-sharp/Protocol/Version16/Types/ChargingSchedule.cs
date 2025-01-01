using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct ChargingSchedule
{
    public static readonly ChargingSchedule Empty = new();

    [JsonProperty("duration")]
    public long? Duration { get; set; }

    [JsonProperty("startSchedule")]
    public DateTime? StartSchedule { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingRateUnitType"/>
    /// </summary>
    [JsonProperty("chargingRateUnit")]
    public ChargingRateUnitType.Enum ChargingRateUnit { get; set; }

    [JsonProperty("chargingSchedulePeriod")]
    public ChargingSchedulePeriod[] ChargingSchedulePeriod { get; set; }

    [JsonProperty("minChargingRate")]
    public double? MinChargingRate { get; set; }
}
