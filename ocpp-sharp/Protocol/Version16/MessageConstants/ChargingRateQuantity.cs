using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;


/// <summary>
/// Relates to <see cref="ChargingRateUnitType"/> 
/// </summary>
public static class ChargingRateQuantityType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChargingRateQuantityType.Power)]
        Power,

        [StringValue(ChargingRateQuantityType.Current)]
        Current
    }

    public const string Power = "Power";
    public const string Current = "Current";
}
