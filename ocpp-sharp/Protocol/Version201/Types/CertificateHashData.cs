using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct CertificateHashData
{
    public static readonly CertificateHashData Empty = new();

    [JsonProperty("hashAlgorithm")]
    public HashAlgorithmType.Enum HashAlgorithm { get; set; }

    [JsonProperty("issuerNameHash")]
    public CiString IssuerNameHash { get; set; }

    [JsonProperty("issuerKeyHash")]
    public string IssuerKeyHash { get; set; }

    [JsonProperty("serialNumber")]
    public CiString SerialNumber { get; set; }
}
