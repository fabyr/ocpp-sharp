using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class AvailabilityStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(AvailabilityStatus.Accepted)]
        Accepted,

        [StringValue(AvailabilityStatus.Rejected)]
        Rejected,

        [StringValue(AvailabilityStatus.Scheduled)]
        Scheduled
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string Scheduled = "Scheduled";
}
