using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class ChargingProfileKindType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingProfileKindType.Absolute)]
            Absolute,
            [StringValue(ChargingProfileKindType.Recurring)]
            Recurring,
            [StringValue(ChargingProfileKindType.Relative)]
            Relative
        }
        public const string Absolute = "Absolute";
        public const string Recurring  = "Recurring";
        public const string Relative  = "Relative";
    }
}