using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingSchedule
{
    public static readonly ChargingSchedule Empty = new();

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("startSchedule")]
    public DateTime? StartSchedule { get; set; }

    [JsonProperty("duration")]
    public int? Duration { get; set; }
}
