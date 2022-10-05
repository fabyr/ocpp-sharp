using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class ChargingRateUnitType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingRateUnitType.Watt)]
            Watt,
            [StringValue(ChargingRateUnitType.Ampere)]
            Ampere
        }

        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum QuantityEnum
        {
            [StringValue("Power")]
            Power,
            [StringValue("Current")]
            Current
        }

        public const string Watt = "W";
        public const string Ampere = "A";
    }
}