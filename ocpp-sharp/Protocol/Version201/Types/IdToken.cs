using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct IdToken
{
    public static readonly IdToken Empty = new();

    [JsonProperty("idToken")]
    public CiString IdTokenValue { get; set; }

    [JsonProperty("type")]
    public IdTokenType.Enum Type { get; set; }

    [JsonProperty("additionalInfo")]
    public AdditionalInfo[]? AdditionalInfo { get; set; }
}
