using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ReportData
{
    public static readonly ReportData Empty = new();

    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable Variable { get; set; }

    /// <summary>
    /// Must contain at least one entry.
    /// </summary>
    [JsonPropertyName("variableAttribute")]
    public VariableAttribute[] VariableAttribute { get; set; }

    [JsonPropertyName("variableCharacteristics")]
    public VariableCharacteristics? VariableCharacteristics { get; set; }
}
