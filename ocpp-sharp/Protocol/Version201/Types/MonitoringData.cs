using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct MonitoringData
{
    public static readonly MonitoringData Empty = new();

    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable Variable { get; set; }

    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonProperty("variableMonitoring")]
    public VariableMonitoring[] VariableMonitoring { get; set; }
}
