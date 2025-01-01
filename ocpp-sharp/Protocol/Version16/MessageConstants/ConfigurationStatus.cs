using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ConfigurationStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ConfigurationStatus.Accepted)]
        Accepted,

        [StringValue(ConfigurationStatus.Rejected)]
        Rejected,

        [StringValue(ConfigurationStatus.RebootRequired)]
        RebootRequired,

        [StringValue(ConfigurationStatus.NotSupported)]
        NotSupported
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string RebootRequired = "RebootRequired";
    public const string NotSupported = "NotSupported";
}
