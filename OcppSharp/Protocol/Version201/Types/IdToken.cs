using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types;

public struct IdToken
{
    public static readonly IdToken Empty = new();

    [JsonPropertyName("idToken")]
    public CiString IdTokenValue { get; set; }

    [JsonPropertyName("type")]
    public IdTokenType.Enum Type { get; set; }

    [JsonPropertyName("additionalInfo")]
    public AdditionalInfo[]? AdditionalInfo { get; set; }
}
