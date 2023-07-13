using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class RecurrencyKindType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(RecurrencyKindType.Daily)]
            Daily,
            [StringValue(RecurrencyKindType.Weekly)]
            Weekly
        }
        public const string Daily = "Daily";
        public const string Weekly  = "Weekly";
    }
}