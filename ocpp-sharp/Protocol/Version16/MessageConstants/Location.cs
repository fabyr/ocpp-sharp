using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class Location
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(Location.Body)]
        Body,

        [StringValue(Location.Cable)]
        Cable,

        [StringValue(Location.EV)]
        EV,

        [StringValue(Location.Inlet)]
        Inlet,

        [StringValue(Location.Outlet)]
        Outlet
    }

    public const string Body = "Body";
    public const string Cable = "Cable";
    public const string EV = "EV";
    public const string Inlet = "Inlet";
    public const string Outlet = "Outlet";
}
