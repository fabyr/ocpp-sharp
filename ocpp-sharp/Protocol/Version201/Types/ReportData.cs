using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ReportData
{
    public static readonly ReportData Empty = new();

    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable Variable { get; set; }

    /// <summary>
    /// Must contain at least one entry.
    /// </summary>
    [JsonProperty("variableAttribute")]
    public VariableAttribute[] VariableAttribute { get; set; }

    [JsonProperty("variableCharacteristics")]
    public VariableCharacteristics? VariableCharacteristics { get; set; }
}
