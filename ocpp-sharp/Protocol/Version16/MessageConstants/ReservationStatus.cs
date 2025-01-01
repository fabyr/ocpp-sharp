using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ReservationStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ReservationStatus.Accepted)]
        Accepted,

        [StringValue(ReservationStatus.Faulted)]
        Faulted,

        [StringValue(ReservationStatus.Occupied)]
        Occupied,

        [StringValue(ReservationStatus.Rejected)]
        Rejected,

        [StringValue(ReservationStatus.Unavailable)]
        Unavailable
    }

    public const string Accepted = "Accepted";
    public const string Faulted = "Faulted";
    public const string Occupied = "Occupied";
    public const string Rejected = "Rejected";
    public const string Unavailable = "Unavailable";
}
