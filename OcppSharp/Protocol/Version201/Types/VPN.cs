using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct VPN
{
    public static readonly VPN Empty = new();

    [JsonPropertyName("server")]
    public string Server { get; set; }

    [JsonPropertyName("user")]
    public string User { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("type")]
    public VPNType.Enum Type { get; set; }
}
