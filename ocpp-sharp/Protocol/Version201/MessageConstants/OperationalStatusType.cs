using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class OperationalStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(OperationalStatusType.Inoperative)]
        Inoperative,

        [StringValue(OperationalStatusType.Operative)]
        Operative
    }

    public const string Inoperative = "Inoperative";
    public const string Operative = "Operative";
}
