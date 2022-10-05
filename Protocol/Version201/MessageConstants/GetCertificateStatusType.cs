using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class GetCertificateStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(GetCertificateStatusType.Accepted)]
            Accepted,
            [StringValue(GetCertificateStatusType.Failed)]
            Failed
        }
        public const string Accepted = "Accepted";
        public const string Failed = "Failed";
    }
}