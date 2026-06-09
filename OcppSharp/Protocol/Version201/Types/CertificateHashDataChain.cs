using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct CertificateHashDataChain
{
    public static readonly CertificateHashDataChain Empty = new();

    [JsonPropertyName("certificateType")]
    public GetCertificateIdUseType.Enum CertificateType { get; set; }

    [JsonPropertyName("certificateHashData")]
    public CertificateHashData CertificateHashData { get; set; }

    /// <summary>
    /// Array length must not exceed 4.
    /// </summary>
    [JsonPropertyName("childCertificateHashData")]
    public CertificateHashData[]? ChildCertificateHashData { get; set; }
}
