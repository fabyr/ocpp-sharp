using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ComponentVariable
{
    public static readonly ComponentVariable Empty = new();


    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable? Variable { get; set; }
}
