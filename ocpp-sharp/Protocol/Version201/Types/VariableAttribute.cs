using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct VariableAttribute
{
    public static readonly VariableAttribute Empty = new();

    [JsonProperty("type")]
    public AttributeType.Enum? Type { get; set; }

    [JsonProperty("value")]
    public string? Value { get; set; }

    [JsonProperty("mutability")]
    public MutabilityType.Enum? Mutability { get; set; } // Default = MutabilityType.Enum.ReadWrite
}
