using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class LocationType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(LocationType.Body)]
        Body,

        [StringValue(LocationType.Cable)]
        Cable,

        [StringValue(LocationType.EV)]
        EV,

        [StringValue(LocationType.Inlet)]
        Inlet,

        [StringValue(LocationType.Outlet)]
        Outlet
    }

    public const string Body = "Body";
    public const string Cable = "Cable";
    public const string EV = "EV";
    public const string Inlet = "Inlet";
    public const string Outlet = "Outlet";
}
