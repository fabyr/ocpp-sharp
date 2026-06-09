using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct Component
{
    public static readonly Component Empty = new();

    [JsonPropertyName("name")]
    public CiString Name { get; set; }

    [JsonPropertyName("instance")]
    public CiString? Instance { get; set; }

    [JsonPropertyName("evse")]
    public EVSE? Evse { get; set; }
}
