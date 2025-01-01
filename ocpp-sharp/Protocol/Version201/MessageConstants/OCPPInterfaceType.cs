using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class OCPPInterfaceType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(OCPPInterfaceType.Wired0)]
        Wired0,

        [StringValue(OCPPInterfaceType.Wired1)]
        Wired1,

        [StringValue(OCPPInterfaceType.Wired2)]
        Wired2,

        [StringValue(OCPPInterfaceType.Wired3)]
        Wired3,

        [StringValue(OCPPInterfaceType.Wireless0)]
        Wireless0,

        [StringValue(OCPPInterfaceType.Wireless1)]
        Wireless1,

        [StringValue(OCPPInterfaceType.Wireless2)]
        Wireless2,

        [StringValue(OCPPInterfaceType.Wireless3)]
        Wireless3
    }

    public const string Wired0 = "Wired0";
    public const string Wired1 = "Wired1";
    public const string Wired2 = "Wired2";
    public const string Wired3 = "Wired3";
    public const string Wireless0 = "Wireless0";
    public const string Wireless1 = "Wireless1";
    public const string Wireless2 = "Wireless2";
    public const string Wireless3 = "Wireless3";
}
