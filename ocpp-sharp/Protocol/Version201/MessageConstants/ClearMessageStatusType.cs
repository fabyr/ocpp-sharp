using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ClearMessageStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ClearMessageStatusType.Accepted)]
            Accepted,
            [StringValue(ClearMessageStatusType.Unknown)]
            Unknown
        }
        public const string Accepted = "Accepted";
        public const string Unknown = "Unknown";
    }
}