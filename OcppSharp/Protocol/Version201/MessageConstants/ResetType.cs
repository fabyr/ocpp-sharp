using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ResetType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ResetType.Immediate)]
        Immediate,

        [StringValue(ResetType.OnIdle)]
        OnIdle
    }

    public const string Immediate = "Immediate";
    public const string OnIdle = "OnIdle";
}
