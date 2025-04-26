using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct DCChargingParameters
{
    public static readonly DCChargingParameters Empty = new();

    [JsonPropertyName("evMaxCurrent")]
    public int EvMaxCurrent { get; set; }

    [JsonPropertyName("evMaxVoltage")]
    public int EvMaxVoltage { get; set; }

    [JsonPropertyName("energyAmount")]
    public int EnergyAmount { get; set; }

    [JsonPropertyName("evMaxPower")]
    public int EvMaxPower { get; set; }

    /// <summary>
    /// Value range: [0; 100]
    /// (0 to 100, both inclusive)
    /// </summary>
    [JsonPropertyName("stateOfCharge")]
    public int StateOfCharge { get; set; }
}
