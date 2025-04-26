using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class LogType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
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
