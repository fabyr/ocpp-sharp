using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingSchedule
{
    public static readonly ChargingSchedule Empty = new();

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("startSchedule")]
    public DateTime? StartSchedule { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
}
