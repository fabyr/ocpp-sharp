using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class GetCompositeScheduleStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(GetCompositeScheduleStatus.Accepted)]
            Accepted,
            [StringValue(GetCompositeScheduleStatus.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
    }
}