using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class UnlockStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(UnlockStatus.Unlocked)]
        Unlocked,

        [StringValue(UnlockStatus.UnlockFailed)]
        UnlockFailed,

        [StringValue(UnlockStatus.NotSupported)]
        NotSupported
    }

    public const string Unlocked = "Unlocked";
    public const string UnlockFailed = "UnlockFailed";
    public const string NotSupported = "NotSupported";
}
