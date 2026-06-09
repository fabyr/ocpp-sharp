using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class APNAuthenticationType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(APNAuthenticationType.CHAP)]
        CHAP,

        [StringValue(APNAuthenticationType.NONE)]
        NONE,

        [StringValue(APNAuthenticationType.PAP)]
        PAP,

        [StringValue(APNAuthenticationType.AUTO)]
        AUTO
    }

    public const string CHAP = "CHAP";
    public const string NONE = "NONE";
    public const string PAP = "PAP";
    public const string AUTO = "AUTO";
}
