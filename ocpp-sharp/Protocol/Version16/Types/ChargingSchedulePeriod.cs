using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct ChargingSchedulePeriod
{
    public static readonly ChargingSchedulePeriod Empty = new();

    [JsonPropertyName("startPeriod")]
    public long StartPeriod { get; set; }

    [JsonPropertyName("limit")]
    public double Limit { get; set; }

    [JsonPropertyName("numberPhases")]
    public long? NumberPhases { get; set; }
}
