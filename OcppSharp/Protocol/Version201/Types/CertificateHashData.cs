using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types;

public struct CertificateHashData
{
    public static readonly CertificateHashData Empty = new();

    [JsonPropertyName("hashAlgorithm")]
    public HashAlgorithmType.Enum HashAlgorithm { get; set; }

    [JsonPropertyName("issuerNameHash")]
    public CiString IssuerNameHash { get; set; }

    [JsonPropertyName("issuerKeyHash")]
    public string IssuerKeyHash { get; set; }

    [JsonPropertyName("serialNumber")]
    public CiString SerialNumber { get; set; }
}
