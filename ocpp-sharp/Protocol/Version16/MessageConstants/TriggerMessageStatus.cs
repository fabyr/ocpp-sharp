using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class TriggerMessageStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(TriggerMessageStatus.Accepted)]
        Accepted,

        [StringValue(TriggerMessageStatus.Rejected)]
        Rejected,

        [StringValue(TriggerMessageStatus.NotImplemented)]
        NotImplemented
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string NotImplemented = "NotImplemented";
}
