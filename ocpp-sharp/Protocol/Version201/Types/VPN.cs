using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct VPN
{
    public static readonly VPN Empty = new();

    [JsonProperty("server")]
    public string Server { get; set; }

    [JsonProperty("user")]
    public string User { get; set; }

    [JsonProperty("group")]
    public string? Group { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("type")]
    public VPNType.Enum Type { get; set; }
}
