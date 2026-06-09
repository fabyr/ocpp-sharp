using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct APN
{
    public static readonly APN Empty = new();

    [JsonPropertyName("apn")]
    public string Apn { get; set; }

    [JsonPropertyName("apnUserName")]
    public string? ApnUserName { get; set; }

    [JsonPropertyName("apnPassword")]
    public string? ApnPassword { get; set; }

    [JsonPropertyName("simPin")]
    public int? SimPin { get; set; }

    [JsonPropertyName("preferredNetwork")]
    public CiString? PreferredNetwork { get; set; }

    [JsonPropertyName("useOnlyPreferredNetwork")]
    public bool? UseOnlyPreferredNetwork { get; set; }

    [JsonPropertyName("apnAuthentication")]
    public APNAuthenticationType.Enum ApnAuthentication { get; set; }
}
