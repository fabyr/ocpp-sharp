using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class SendLocalListStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(SendLocalListStatusType.Accepted)]
        Accepted,

        [StringValue(SendLocalListStatusType.Failed)]
        Failed,

        [StringValue(SendLocalListStatusType.VersionMismatch)]
        VersionMismatch
    }

    public const string Accepted = "Accepted";
    public const string Failed = "Failed";
    public const string VersionMismatch = "VersionMismatch";
}
