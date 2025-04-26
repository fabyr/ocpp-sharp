using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ResetType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ResetType.Soft)]
        Soft,

        [StringValue(ResetType.Hard)]
        Hard
    }

    public const string Soft = "Soft";
    public const string Hard = "Hard";
}
