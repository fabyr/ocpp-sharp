using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetCertificateStatus", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetCertificateStatusResponse : ResponsePayload
{
    [JsonProperty("status")]
    public GetCertificateStatusType.Enum Status { get; set; }

    [JsonProperty("ocspResult")]
    public string? OcspResult { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
