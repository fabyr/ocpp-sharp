using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct IdTokenInfo
{
    public static readonly IdTokenInfo Empty = new();

    [JsonProperty("status")]
    public AuthorizationStatusType.Enum Status { get; set; }

    [JsonProperty("cacheExpiryDateTime")]
    public DateTime? CacheExpiryDateTime { get; set; }

    [JsonProperty("chargingPriority")]
    public int? ChargingPriority { get; set; }

    [JsonProperty("language1")]
    public string? Language1 { get; set; }

    [JsonProperty("evseId")]
    public int? EvseId { get; set; }

    [JsonProperty("language2")]
    public string? Language2 { get; set; }

    [JsonProperty("groupIdToken")]
    public IdToken? GroupIdToken { get; set; }

    [JsonProperty("personalMessage")]
    public MessageContent? PersonalMessage { get; set; }
}
