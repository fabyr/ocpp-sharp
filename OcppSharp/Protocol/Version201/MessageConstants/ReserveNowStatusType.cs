using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ReserveNowStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ReserveNowStatusType.Accepted)]
        Accepted,

        [StringValue(ReserveNowStatusType.Faulted)]
        Faulted,

        [StringValue(ReserveNowStatusType.Occupied)]
        Occupied,

        [StringValue(ReserveNowStatusType.Rejected)]
        Rejected,

        [StringValue(ReserveNowStatusType.Unavailable)]
        Unavailable
    }

    public const string Accepted = "Accepted";
    public const string Faulted = "Faulted";
    public const string Occupied = "Occupied";
    public const string Rejected = "Rejected";
    public const string Unavailable = "Unavailable";
}
