using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetCertificateStatus", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetCertificateStatusResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GetCertificateStatusType.Enum Status { get; set; }

    [JsonPropertyName("ocspResult")]
    public string? OcspResult { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
