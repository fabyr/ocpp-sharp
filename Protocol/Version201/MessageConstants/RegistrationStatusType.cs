using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class RegistrationStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(RegistrationStatusType.Accepted)]
            Accepted,
            [StringValue(RegistrationStatusType.Pending)]
            Pending,
            [StringValue(RegistrationStatusType.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Pending = "Pending";
        public const string Rejected = "Rejected";
    }
}