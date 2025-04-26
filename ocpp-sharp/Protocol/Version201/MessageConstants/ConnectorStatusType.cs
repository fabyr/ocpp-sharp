using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ConnectorStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ConnectorStatusType.Available)]
        Available,

        [StringValue(ConnectorStatusType.Occupied)]
        Occupied,

        [StringValue(ConnectorStatusType.Reserved)]
        Reserved,

        [StringValue(ConnectorStatusType.Unavailable)]
        Unavailable,

        [StringValue(ConnectorStatusType.Faulted)]
        Faulted
    }

    public const string Available = "Available";
    public const string Occupied = "Occupied";
    public const string Reserved = "Reserved";
    public const string Unavailable = "Unavailable";
    public const string Faulted = "Faulted";
}
