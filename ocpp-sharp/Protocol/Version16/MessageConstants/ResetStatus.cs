using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class ResetStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ResetStatus.Accepted)]
            Accepted,
            [StringValue(ResetStatus.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
    }
}