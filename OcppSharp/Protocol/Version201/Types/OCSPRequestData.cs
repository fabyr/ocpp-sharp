using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct OCSPRequestData
{
    public static readonly OCSPRequestData Empty = new();

    [JsonPropertyName("hashAlgorithm")]
    public HashAlgorithmType.Enum HashAlgorithm { get; set; }

    [JsonPropertyName("issuerNameHash")]
    public CiString IssuerNameHash { get; set; }

    [JsonPropertyName("issuerKeyHash")]
    public string IssuerKeyHash { get; set; }

    [JsonPropertyName("serialNumber")]
    public CiString SerialNumber { get; set; }

    [JsonPropertyName("responderURL")]
    public CiString ResponderURL { get; set; }
}
