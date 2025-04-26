using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class GetDisplayMessagesStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
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
