using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetInstalledCertificateIds", OcppMessageAttribute.Direction.PointToCentral)]
public class GetInstalledCertificateIdsResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GetInstalledCertificateStatusType.Enum Status { get; set; }

    [JsonPropertyName("certificateHashDataChain")]
    public CertificateHashDataChain[]? CertificateHashDataChain { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
