using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct GetVariableData
{
    public static readonly GetVariableData Empty = new();

    [JsonPropertyName("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable Variable { get; set; }
}
