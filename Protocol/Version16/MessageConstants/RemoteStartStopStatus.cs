using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class RemoteStartStopStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(RemoteStartStopStatus.Accepted)]
            Accepted,
            [StringValue(RemoteStartStopStatus.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Rejected  = "Rejected";
    }
}