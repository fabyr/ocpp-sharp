using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ChargingRateUnitType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingRateUnitType.W)]
            W,
            [StringValue(ChargingRateUnitType.A)]
            A
        }
        public const string W = "W";
        public const string A = "A";
    }
}