using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct IdTokenInfo
{
    public static readonly IdTokenInfo Empty = new();

    [JsonPropertyName("status")]
    public AuthorizationStatusType.Enum Status { get; set; }

    [JsonPropertyName("cacheExpiryDateTime")]
    public DateTime? CacheExpiryDateTime { get; set; }

    [JsonPropertyName("chargingPriority")]
    public int? ChargingPriority { get; set; }

    [JsonPropertyName("language1")]
    public string? Language1 { get; set; }

    [JsonPropertyName("evseId")]
    public int? EvseId { get; set; }

    [JsonPropertyName("language2")]
    public string? Language2 { get; set; }

    [JsonPropertyName("groupIdToken")]
    public IdToken? GroupIdToken { get; set; }

    [JsonPropertyName("personalMessage")]
    public MessageContent? PersonalMessage { get; set; }
}
