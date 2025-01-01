using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct LogParameters
{
    public static readonly LogParameters Empty = new();

    [JsonProperty("remoteLocation")]
    public string RemoteLocation { get; set; }

    [JsonProperty("oldestTimestamp")]
    public DateTime? OldestTimestamp { get; set; }

    [JsonProperty("latestTimestamp")]
    public DateTime? LatestTimestamp { get; set; }
}
