using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ChargingRateUnitType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChargingRateUnitType.Watt)]
        Watt,

        [StringValue(ChargingRateUnitType.Ampere)]
        Ampere
    }

    public const string Watt = "W";
    public const string Ampere = "A";
}
