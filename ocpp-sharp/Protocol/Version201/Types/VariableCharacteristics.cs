using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct VariableCharacteristics
{
    public static readonly VariableCharacteristics Empty = new();

    [JsonProperty("unit")]
    public CiString? Unit { get; set; }

    [JsonProperty("dataType")]
    public DataType.Enum DataType { get; set; }

    [JsonProperty("minLimit")]
    public double? MinLimit { get; set; }

    [JsonProperty("maxLimit")]
    public double? MaxLimit { get; set; }

    [JsonProperty("valuesList")]
    public string? ValuesList { get; set; }

    [JsonProperty("supportsMonitoring")]
    public bool SupportsMonitoring { get; set; }
}
