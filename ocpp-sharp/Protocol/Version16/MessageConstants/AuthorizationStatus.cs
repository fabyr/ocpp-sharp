using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class AuthorizationStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(AuthorizationStatus.Accepted)]
        Accepted,

        [StringValue(AuthorizationStatus.Blocked)]
        Blocked,

        [StringValue(AuthorizationStatus.Expired)]
        Expired,

        [StringValue(AuthorizationStatus.Invalid)]
        Invalid
    }

    public const string Accepted = "Accepted";
    public const string Blocked = "Blocked";
    public const string Expired = "Expired";
    public const string Invalid = "Invalid";
}
