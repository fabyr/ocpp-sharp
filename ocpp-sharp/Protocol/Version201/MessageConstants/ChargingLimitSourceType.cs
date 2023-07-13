using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ChargingLimitSourceType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingLimitSourceType.EMS)]
            EMS,
            [StringValue(ChargingLimitSourceType.Other)]
            Other,
            [StringValue(ChargingLimitSourceType.SO)]
            SO,
            [StringValue(ChargingLimitSourceType.CSO)]
            CSO
        }
        public const string EMS = "EMS";
        public const string Other = "Other";
        public const string SO = "SO";
        public const string CSO = "CSO";
    }
}