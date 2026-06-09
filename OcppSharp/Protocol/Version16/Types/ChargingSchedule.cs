using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct ChargingSchedule
{
    public static readonly ChargingSchedule Empty = new();

    [JsonPropertyName("duration")]
    public long? Duration { get; set; }

    [JsonPropertyName("startSchedule")]
    public DateTime? StartSchedule { get; set; }

    /// <summary>
    /// Valid values in <see cref="ChargingRateUnitType"/>
    /// </summary>
    [JsonPropertyName("chargingRateUnit")]
    public ChargingRateUnitType.Enum ChargingRateUnit { get; set; }

    [JsonPropertyName("chargingSchedulePeriod")]
    public ChargingSchedulePeriod[] ChargingSchedulePeriod { get; set; }

    [JsonPropertyName("minChargingRate")]
    public double? MinChargingRate { get; set; }
}
