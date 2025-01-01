using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class AuthorizationStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(AuthorizationStatusType.Accepted)]
        Accepted,

        [StringValue(AuthorizationStatusType.Blocked)]
        Blocked,

        [StringValue(AuthorizationStatusType.ConcurrentTx)]
        ConcurrentTx,

        [StringValue(AuthorizationStatusType.Expired)]
        Expired,

        [StringValue(AuthorizationStatusType.Invalid)]
        Invalid,

        [StringValue(AuthorizationStatusType.NoCredit)]
        NoCredit,

        [StringValue(AuthorizationStatusType.NotAllowedTypeEVSE)]
        NotAllowedTypeEVSE,

        [StringValue(AuthorizationStatusType.NotAtThisLocation)]
        NotAtThisLocation,

        [StringValue(AuthorizationStatusType.NotAtThisTime)]
        NotAtThisTime,

        [StringValue(AuthorizationStatusType.Unknown)]
        Unknown
    }

    public const string Accepted = "Accepted";
    public const string Blocked = "Blocked";
    public const string ConcurrentTx = "ConcurrentTx";
    public const string Expired = "Expired";
    public const string Invalid = "Invalid";
    public const string NoCredit = "NoCredit";
    public const string NotAllowedTypeEVSE = "NotAllowedTypeEVSE";
    public const string NotAtThisLocation = "NotAtThisLocation";
    public const string NotAtThisTime = "NotAtThisTime";
    public const string Unknown = "Unknown";
}
