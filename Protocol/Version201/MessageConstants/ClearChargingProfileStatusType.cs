using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ClearChargingProfileStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ClearChargingProfileStatusType.Accepted)]
            Accepted,
            [StringValue(ClearChargingProfileStatusType.Unknown)]
            Unknown
        }
        public const string Accepted = "Accepted";
        public const string Unknown = "Unknown";
    }
}