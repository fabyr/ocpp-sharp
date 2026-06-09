using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class GenericStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(GenericStatusType.Accepted)]
        Accepted,

        [StringValue(GenericStatusType.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
