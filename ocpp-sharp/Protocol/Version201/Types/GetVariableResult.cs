using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct GetVariableResult
{
    public static readonly GetVariableResult Empty = new();

    [JsonProperty("attributeStatus")]
    public GetVariableStatusType.Enum AttributeStatus { get; set; }

    [JsonProperty("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonProperty("attributeValue")]
    public string? AttributeValue { get; set; }

    [JsonProperty("component")]
    public Component Component { get; set; }
}
