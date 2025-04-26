using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class CancelReservationStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(CancelReservationStatus.Accepted)]
        Accepted,

        [StringValue(CancelReservationStatus.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
