using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetVariableResult
{
    public static readonly SetVariableResult Empty = new();

    [JsonPropertyName("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonPropertyName("attributeStatus")]
    public SetVariableStatusType.Enum AttributeStatus { get; set; }

    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable Variable { get; set; }

    [JsonPropertyName("attributeStatusInfo")]
    public StatusInfo? AttributeStatusInfo { get; set; }
}
