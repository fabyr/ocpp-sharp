using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetVariableData
{
    public static readonly SetVariableData Empty = new();

    [JsonProperty("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonProperty("attributeValue")]
    public string AttributeValue { get; set; }

    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable Variable { get; set; }
}
