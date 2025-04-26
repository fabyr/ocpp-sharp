using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ACChargingParameters
{
    public static readonly ACChargingParameters Empty = new();

    [JsonPropertyName("energyAmount")]
    public int EnergyAmount { get; set; }

    [JsonPropertyName("evMinCurrent")]
    public int EvMinCurrent { get; set; }

    [JsonPropertyName("evMaxCurrent")]
    public int EvMaxCurrent { get; set; }

    [JsonPropertyName("evMaxVoltage")]
    public int EvMaxVoltage { get; set; }
}
