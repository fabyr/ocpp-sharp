using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class LogType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(LogType.DiagnosticsLog)]
            DiagnosticsLog,
            [StringValue(LogType.SecurityLog)]
            SecurityLog
        }
        public const string DiagnosticsLog = "DiagnosticsLog";
        public const string SecurityLog = "SecurityLog";
    }
}