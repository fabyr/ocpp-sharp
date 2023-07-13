using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ChargingProfileStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingProfileStatusType.Accepted)]
            Accepted,
            [StringValue(ChargingProfileStatusType.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
    }
}