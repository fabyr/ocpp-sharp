using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class DisplayMessageStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(DisplayMessageStatusType.Accepted)]
        Accepted,

        [StringValue(DisplayMessageStatusType.NotSupportedMessageFormat)]
        NotSupportedMessageFormat,

        [StringValue(DisplayMessageStatusType.Rejected)]
        Rejected,

        [StringValue(DisplayMessageStatusType.NotSupportedPriority)]
        NotSupportedPriority,

        [StringValue(DisplayMessageStatusType.NotSupportedState)]
        NotSupportedState,

        [StringValue(DisplayMessageStatusType.UnknownTransaction)]
        UnknownTransaction
    }

    public const string Accepted = "Accepted";
    public const string NotSupportedMessageFormat = "NotSupportedMessageFormat";
    public const string Rejected = "Rejected";
    public const string NotSupportedPriority = "NotSupportedPriority";
    public const string NotSupportedState = "NotSupportedState";
    public const string UnknownTransaction = "UnknownTransaction";
}
