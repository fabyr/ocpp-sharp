using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct AuthorizationData
{
    public static readonly AuthorizationData Empty = new();

    [JsonPropertyName("idTokenInfo")]
    public IdTokenInfo? IdTokenInfo { get; set; }

    [JsonPropertyName("idToken")]
    public IdToken IdToken { get; set; }
}
