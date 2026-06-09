using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct MonitoringData
{
    public static readonly MonitoringData Empty = new();

    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable Variable { get; set; }

    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonPropertyName("variableMonitoring")]
    public VariableMonitoring[] VariableMonitoring { get; set; }
}
