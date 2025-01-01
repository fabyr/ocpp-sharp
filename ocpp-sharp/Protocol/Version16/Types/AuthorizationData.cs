using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct AuthorizationData
{
    public static readonly AuthorizationData Empty = new();

    [JsonProperty("idTag")]
    public CiString IdTag { get; set; }

    [JsonProperty("idTagInfo")]
    public IdTagInfo? IdTagInfo { get; set; }
}
