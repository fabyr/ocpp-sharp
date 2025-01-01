using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ComponentVariable
{
    public static readonly ComponentVariable Empty = new();


    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable? Variable { get; set; }
}
