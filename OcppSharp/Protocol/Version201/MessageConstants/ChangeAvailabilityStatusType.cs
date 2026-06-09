using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ChangeAvailabilityStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChangeAvailabilityStatusType.Accepted)]
        Accepted,

        [StringValue(ChangeAvailabilityStatusType.Rejected)]
        Rejected,

        [StringValue(ChangeAvailabilityStatusType.Scheduled)]
        Scheduled
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string Scheduled = "Scheduled";
}
