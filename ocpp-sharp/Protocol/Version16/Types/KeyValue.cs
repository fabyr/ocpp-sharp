using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct KeyValue
{
    public static readonly KeyValue Empty = new();

    [JsonProperty("key")]
    public CiString Key { get; set; }

    [JsonProperty("readonly")]
    public bool ReadOnly { get; set; }

    [JsonProperty("value")]
    public CiString? Value { get; set; }
}
