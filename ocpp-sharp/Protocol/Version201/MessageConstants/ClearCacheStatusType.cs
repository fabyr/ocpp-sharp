using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ClearCacheStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ClearCacheStatusType.Accepted)]
        Accepted,

        [StringValue(ClearCacheStatusType.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
