using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct SignedMeterValue
{
    public static readonly SignedMeterValue Empty = new();

    [JsonPropertyName("signedMeterData")]
    public string SignedMeterData { get; set; }

    [JsonPropertyName("signingMethod")]
    public string SigningMethod { get; set; }

    [JsonPropertyName("encodingMethod")]
    public string EncodingMethod { get; set; }

    [JsonPropertyName("publicKey")]
    public string PublicKey { get; set; }
}
