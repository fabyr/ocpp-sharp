using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class NotifyEVChargingNeedsStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(NotifyEVChargingNeedsStatusType.Accepted)]
            Accepted,
            [StringValue(NotifyEVChargingNeedsStatusType.Rejected)]
            Rejected,
            [StringValue(NotifyEVChargingNeedsStatusType.Processing)]
            Processing
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
        public const string Processing = "Processing";
    }
}