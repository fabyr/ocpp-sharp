using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class GetDisplayMessagesStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(GetDisplayMessagesStatusType.Accepted)]
            Accepted,
            [StringValue(GetDisplayMessagesStatusType.Unknown)]
            Unknown
        }
        public const string Accepted = "Accepted";
        public const string Unknown = "Unknown";
    }
}