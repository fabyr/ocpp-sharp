using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class TriggerMessageStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(TriggerMessageStatusType.Accepted)]
        Accepted,

        [StringValue(TriggerMessageStatusType.Rejected)]
        Rejected,

        [StringValue(TriggerMessageStatusType.NotImplemented)]
        NotImplemented
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string NotImplemented = "NotImplemented";
}
