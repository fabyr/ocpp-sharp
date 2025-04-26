using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class HashAlgorithmType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(HashAlgorithmType.SHA256)]
        SHA256,

        [StringValue(HashAlgorithmType.SHA384)]
        SHA384,

        [StringValue(HashAlgorithmType.SHA512)]
        SHA512
    }

    public const string SHA256 = "SHA256";
    public const string SHA384 = "SHA384";
    public const string SHA512 = "SHA512";
}
