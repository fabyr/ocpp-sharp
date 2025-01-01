using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetInstalledCertificateIds", OcppMessageAttribute.Direction.PointToCentral)]
public class GetInstalledCertificateIdsResponse : ResponsePayload
{
    [JsonProperty("status")]
    public GetInstalledCertificateStatusType.Enum Status { get; set; }

    [JsonProperty("certificateHashDataChain")]
    public CertificateHashDataChain[]? CertificateHashDataChain { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
