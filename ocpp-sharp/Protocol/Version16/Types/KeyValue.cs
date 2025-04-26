using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct KeyValue
{
    public static readonly KeyValue Empty = new();

    [JsonPropertyName("key")]
    public CiString Key { get; set; }

    [JsonPropertyName("readonly")]
    public bool ReadOnly { get; set; }

    [JsonPropertyName("value")]
    public CiString? Value { get; set; }
}
