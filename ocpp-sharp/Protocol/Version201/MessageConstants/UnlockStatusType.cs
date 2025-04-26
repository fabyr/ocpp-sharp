using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class UnlockStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(UnlockStatusType.Unlocked)]
        Unlocked,

        [StringValue(UnlockStatusType.UnlockFailed)]
        UnlockFailed,

        [StringValue(UnlockStatusType.OngoingAuthorizedTransaction)]
        OngoingAuthorizedTransaction,

        [StringValue(UnlockStatusType.UnknownConnector)]
        UnknownConnector
    }

    public const string Unlocked = "Unlocked";
    public const string UnlockFailed = "UnlockFailed";
    public const string OngoingAuthorizedTransaction = "OngoingAuthorizedTransaction";
    public const string UnknownConnector = "UnknownConnector";
}
