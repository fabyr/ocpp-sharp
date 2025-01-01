using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct SignedMeterValue
{
    public static readonly SignedMeterValue Empty = new();

    [JsonProperty("signedMeterData")]
    public string SignedMeterData { get; set; }

    [JsonProperty("signingMethod")]
    public string SigningMethod { get; set; }

    [JsonProperty("encodingMethod")]
    public string EncodingMethod { get; set; }

    [JsonProperty("publicKey")]
    public string PublicKey { get; set; }
}
