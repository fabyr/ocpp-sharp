using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingSchedulePeriod
{
    public static readonly ChargingSchedulePeriod Empty = new();

    [JsonProperty("startPeriod")]
    public long StartPeriod { get; set; }

    [JsonProperty("limit")]
    public double Limit { get; set; }

    [JsonProperty("numberPhases")]
    public int? NumberPhases { get; set; }

    [JsonProperty("phaseToUse")]
    public int? PhaseToUse { get; set; }
}
