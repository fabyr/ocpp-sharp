using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class CancelReservationStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(CancelReservationStatusType.Accepted)]
        Accepted,

        [StringValue(CancelReservationStatusType.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
