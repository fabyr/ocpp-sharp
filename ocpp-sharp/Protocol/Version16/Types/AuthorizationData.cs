using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct AuthorizationData
{
    public static readonly AuthorizationData Empty = new();

    [JsonPropertyName("idTag")]
    public CiString IdTag { get; set; }

    [JsonPropertyName("idTagInfo")]
    public IdTagInfo? IdTagInfo { get; set; }
}
