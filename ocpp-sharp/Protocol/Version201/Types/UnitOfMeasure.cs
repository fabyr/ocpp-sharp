using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct UnitOfMeasure
{
    public static readonly UnitOfMeasure Empty = new();

    [JsonProperty("unit")]
    public string? Unit { get; set; } // From list of Standardized Units in Part 2 Appendices

    /// <summary>
    /// The value is multiplied by 10^multiplier (power)
    /// </summary>
    [JsonProperty("multiplier")]
    public int? Multiplier { get; set; } // Default is 0
}
