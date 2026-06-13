using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingLimit
{
    public static readonly ChargingLimit Empty = new();

    [JsonPropertyName("chargingLimitSource")]
    public ChargingLimitSourceType.Enum ChargingLimitSource { get; set; }

    [JsonPropertyName("isGridCritical")]
    public bool? IsGridCritical { get; set; }
}
