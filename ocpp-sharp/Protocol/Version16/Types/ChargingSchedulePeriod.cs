using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct ChargingSchedulePeriod
{
    public static readonly ChargingSchedulePeriod Empty = new();

    [JsonProperty("startPeriod")]
    public long StartPeriod { get; set; }

    [JsonProperty("limit")]
    public double Limit { get; set; }

    [JsonProperty("numberPhases")]
    public long? NumberPhases { get; set; }
}
