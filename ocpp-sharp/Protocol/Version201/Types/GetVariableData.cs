using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct GetVariableData
{
    public static readonly GetVariableData Empty = new();

    [JsonProperty("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable Variable { get; set; }
}
