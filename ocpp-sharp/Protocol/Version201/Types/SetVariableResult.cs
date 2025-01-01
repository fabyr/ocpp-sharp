using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct SetVariableResult
{
    public static readonly SetVariableResult Empty = new();

    [JsonProperty("attributeType")]
    public AttributeType.Enum? AttributeType { get; set; }

    [JsonProperty("attributeStatus")]
    public SetVariableStatusType.Enum AttributeStatus { get; set; }

    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable Variable { get; set; }

    [JsonProperty("attributeStatusInfo")]
    public StatusInfo? AttributeStatusInfo { get; set; }
}
