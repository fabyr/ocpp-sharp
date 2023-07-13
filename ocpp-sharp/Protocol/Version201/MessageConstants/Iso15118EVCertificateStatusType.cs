using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class Iso15118EVCertificateStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(Iso15118EVCertificateStatusType.Accepted)]
            Accepted,
            [StringValue(Iso15118EVCertificateStatusType.Failed)]
            Failed
        }
        public const string Accepted = "Accepted";
        public const string Failed = "Failed";
    }
}