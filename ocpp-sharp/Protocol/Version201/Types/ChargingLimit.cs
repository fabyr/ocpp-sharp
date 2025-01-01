using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingLimit
{
    public static readonly ChargingLimit Empty = new();

    [JsonProperty("chargingLimitSource")]
    public ChargingLimitSourceType.Enum ChargingLimitSource { get; set; }

    [JsonProperty("isGridCritical")]
    public bool? IsGridCritical { get; set; }
}
