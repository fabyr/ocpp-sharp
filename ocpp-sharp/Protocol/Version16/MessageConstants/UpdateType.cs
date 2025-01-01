using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class UpdateType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(UpdateType.Differential)]
        Differential,

        [StringValue(UpdateType.Full)]
        Full
    }

    public const string Differential = "Differential";
    public const string Full = "Full";
}
