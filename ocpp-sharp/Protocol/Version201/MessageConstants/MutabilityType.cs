using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class MutabilityType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(MutabilityType.ReadOnly)]
        ReadOnly,

        [StringValue(MutabilityType.WriteOnly)]
        WriteOnly,

        [StringValue(MutabilityType.ReadWrite)]
        ReadWrite
    }

    public const string ReadOnly = "ReadOnly";
    public const string WriteOnly = "WriteOnly";
    public const string ReadWrite = "ReadWrite";
}
