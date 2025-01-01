using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class RegistrationStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(RegistrationStatus.Accepted)]
        Accepted,

        [StringValue(RegistrationStatus.Pending)]
        Pending,

        [StringValue(RegistrationStatus.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Pending = "Pending";
    public const string Rejected = "Rejected";
}
