using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct CertificateHashDataChain
{
    public static readonly CertificateHashDataChain Empty = new();

    [JsonProperty("certificateType")]
    public GetCertificateIdUseType.Enum CertificateType { get; set; }

    [JsonProperty("certificateHashData")]
    public CertificateHashData CertificateHashData { get; set; }

    /// <summary>
    /// Array length must not exceed 4.
    /// </summary>
    [JsonProperty("childCertificateHashData")]
    public CertificateHashData[]? ChildCertificateHashData { get; set; }
}
