using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class AuthorizationStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(AuthorizationStatus.Accepted)]
            Accepted,
            [StringValue(AuthorizationStatus.Blocked)]
            Blocked,
            [StringValue(AuthorizationStatus.Expired)]
            Expired,
            [StringValue(AuthorizationStatus.Invalid)]
            Invalid
        }

        public const string Accepted = "Accepted";
        public const string Blocked = "Blocked";
        public const string Expired = "Expired";
        public const string Invalid = "Invalid";
    }
}