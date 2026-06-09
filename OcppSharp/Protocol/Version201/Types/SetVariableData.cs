using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetVariableData
{
    public static readonly SetVariableData Empty = new();

    [JsonPropertyName("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonPropertyName("attributeValue")]
    public string AttributeValue { get; set; }

    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable Variable { get; set; }
}
