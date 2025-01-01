using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct DCChargingParameters
{
    public static readonly DCChargingParameters Empty = new();

    [JsonProperty("evMaxCurrent")]
    public int EvMaxCurrent { get; set; }

    [JsonProperty("evMaxVoltage")]
    public int EvMaxVoltage { get; set; }

    [JsonProperty("energyAmount")]
    public int EnergyAmount { get; set; }

    [JsonProperty("evMaxPower")]
    public int EvMaxPower { get; set; }

    /// <summary>
    /// Value range: [0; 100]
    /// (0 to 100, both inclusive)
    /// </summary>
    [JsonProperty("stateOfCharge")]
    public int StateOfCharge { get; set; }
}
