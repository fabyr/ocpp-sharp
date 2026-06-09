using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct Firmware
{
    public static readonly Firmware Empty = new();

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("retrieveDateTime")]
    public DateTime RetrieveDateTime { get; set; }

    [JsonPropertyName("installDateTime")]
    public DateTime? InstallDateTime { get; set; }

    [JsonPropertyName("signingCertificate")]
    public string? SigningCertificate { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }
}
