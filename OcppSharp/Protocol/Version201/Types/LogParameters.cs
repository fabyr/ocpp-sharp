using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct LogParameters
{
    public static readonly LogParameters Empty = new();

    [JsonPropertyName("remoteLocation")]
    public string RemoteLocation { get; set; }

    [JsonPropertyName("oldestTimestamp")]
    public DateTime? OldestTimestamp { get; set; }

    [JsonPropertyName("latestTimestamp")]
    public DateTime? LatestTimestamp { get; set; }
}
