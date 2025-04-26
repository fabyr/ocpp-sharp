using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class AvailabilityType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(AvailabilityType.Inoperative)]
        Inoperative,

        [StringValue(AvailabilityType.Operative)]
        Operative
    }

    public const string Inoperative = "Inoperative";
    public const string Operative = "Operative";
}
