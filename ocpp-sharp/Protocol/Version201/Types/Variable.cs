using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct Variable
{
    public static readonly Variable Empty = new();

    [JsonProperty("name")]
    public CiString Name { get; set; }

    [JsonProperty("instance")]
    public CiString? Instance { get; set; }
}
