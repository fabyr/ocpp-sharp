using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ACChargingParameters
{
    public static readonly ACChargingParameters Empty = new();

    [JsonProperty("energyAmount")]
    public int EnergyAmount { get; set; }

    [JsonProperty("evMinCurrent")]
    public int EvMinCurrent { get; set; }

    [JsonProperty("evMaxCurrent")]
    public int EvMaxCurrent { get; set; }

    [JsonProperty("evMaxVoltage")]
    public int EvMaxVoltage { get; set; }
}
