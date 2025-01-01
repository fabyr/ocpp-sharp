using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ClearCacheStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ClearCacheStatus.Accepted)]
        Accepted,

        [StringValue(ClearCacheStatus.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
