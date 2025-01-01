using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct VariableMonitoring
{
    public static readonly VariableMonitoring Empty = new();

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("transaction")]
    public bool Transaction { get; set; }

    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("type")]
    public MonitorType.Enum Type { get; set; }

    [JsonProperty("severity")]
    public int Severity { get; set; }
}
