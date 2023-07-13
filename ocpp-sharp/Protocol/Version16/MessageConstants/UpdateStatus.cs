using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class UpdateStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(UpdateStatus.Accepted)]
            Accepted,
            [StringValue(UpdateStatus.Failed)]
            Failed,
            [StringValue(UpdateStatus.NotSupported)]
            NotSupported,
            [StringValue(UpdateStatus.VersionMismatch)]
            VersionMismatch
        }
        public const string Accepted = "Accepted";
        public const string Failed = "Failed";
        public const string NotSupported = "NotSupported";
        public const string VersionMismatch = "VersionMismatch";
    }
}