using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct AuthorizationData
{
    public static readonly AuthorizationData Empty = new();

    [JsonProperty("idTokenInfo")]
    public IdTokenInfo? IdTokenInfo { get; set; }

    [JsonProperty("idToken")]
    public IdToken IdToken { get; set; }
}
