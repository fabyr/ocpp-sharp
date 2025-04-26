using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct VariableAttribute
{
    public static readonly VariableAttribute Empty = new();

    [JsonPropertyName("type")]
    public AttributeType.Enum? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("mutability")]
    public MutabilityType.Enum? Mutability { get; set; } // Default = MutabilityType.Enum.ReadWrite
}
