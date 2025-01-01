using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct APN
{
    public static readonly APN Empty = new();

    [JsonProperty("apn")]
    public string Apn { get; set; }

    [JsonProperty("apnUserName")]
    public string? ApnUserName { get; set; }

    [JsonProperty("apnPassword")]
    public string? ApnPassword { get; set; }

    [JsonProperty("simPin")]
    public int? SimPin { get; set; }

    [JsonProperty("preferredNetwork")]
    public CiString? PreferredNetwork { get; set; }

    [JsonProperty("useOnlyPreferredNetwork")]
    public bool? UseOnlyPreferredNetwork { get; set; }

    [JsonProperty("apnAuthentication")]
    public APNAuthenticationType.Enum ApnAuthentication { get; set; }
}
