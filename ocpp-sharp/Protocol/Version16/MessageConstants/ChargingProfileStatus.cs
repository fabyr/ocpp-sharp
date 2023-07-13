using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class ChargingProfileStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingProfileStatus.Accepted)]
            Accepted,
            [StringValue(ChargingProfileStatus.Rejected)]
            Rejected,
            [StringValue(ChargingProfileStatus.NotSupported)]
            NotSupported
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
        public const string NotSupported = "NotSupported";
    }
}