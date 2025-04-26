using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct GetVariableResult
{
    public static readonly GetVariableResult Empty = new();

    [JsonPropertyName("attributeStatus")]
    public GetVariableStatusType.Enum AttributeStatus { get; set; }

    [JsonPropertyName("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    [JsonPropertyName("component")]
    public Component Component { get; set; }
}
