using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class IdTokenType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(IdTokenType.Central)]
        Central,

        [StringValue(IdTokenType.eMAID)]
        eMAID,

        [StringValue(IdTokenType.ISO14443)]
        ISO14443,

        [StringValue(IdTokenType.ISO15693)]
        ISO15693,

        [StringValue(IdTokenType.KeyCode)]
        KeyCode,

        [StringValue(IdTokenType.Local)]
        Local,

        [StringValue(IdTokenType.MacAddress)]
        MacAddress,

        [StringValue(IdTokenType.NoAuthorization)]
        NoAuthorization
    }

    public const string Central = "Central";
    public const string eMAID = "eMAID";
    public const string ISO14443 = "ISO14443";
    public const string ISO15693 = "ISO15693";
    public const string KeyCode = "KeyCode";
    public const string Local = "Local";
    public const string MacAddress = "MacAddress";
    public const string NoAuthorization = "NoAuthorization";
}
