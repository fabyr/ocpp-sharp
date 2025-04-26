using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct VariableCharacteristics
{
    public static readonly VariableCharacteristics Empty = new();

    [JsonPropertyName("unit")]
    public CiString? Unit { get; set; }

    [JsonPropertyName("dataType")]
    public DataType.Enum DataType { get; set; }

    [JsonPropertyName("minLimit")]
    public double? MinLimit { get; set; }

    [JsonPropertyName("maxLimit")]
    public double? MaxLimit { get; set; }

    [JsonPropertyName("valuesList")]
    public string? ValuesList { get; set; }

    [JsonPropertyName("supportsMonitoring")]
    public bool SupportsMonitoring { get; set; }
}
