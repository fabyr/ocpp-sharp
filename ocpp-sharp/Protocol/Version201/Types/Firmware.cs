using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct Firmware
{
    public static readonly Firmware Empty = new();

    [JsonProperty("location")]
    public string Location { get; set; }

    [JsonProperty("retrieveDateTime")]
    public DateTime RetrieveDateTime { get; set; }

    [JsonProperty("installDateTime")]
    public DateTime? InstallDateTime { get; set; }

    [JsonProperty("signingCertificate")]
    public string? SigningCertificate { get; set; }

    [JsonProperty("signature")]
    public string? Signature { get; set; }
}
