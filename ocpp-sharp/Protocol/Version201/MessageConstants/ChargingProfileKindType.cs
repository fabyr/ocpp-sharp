using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ChargingProfileKindType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChargingProfileKindType.Absolute)]
        Absolute,

        [StringValue(ChargingProfileKindType.Recurring)]
        Recurring,

        [StringValue(ChargingProfileKindType.Relative)]
        Relative
    }

    public const string Absolute = "Absolute";
    public const string Recurring = "Recurring";
    public const string Relative = "Relative";
}
