using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Get15118EVCertificate", OcppMessageAttribute.Direction.PointToCentral)]
public class Get15118EVCertificateResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public Iso15118EVCertificateStatusType.Enum Status { get; set; }

    [JsonPropertyName("exiResponse")]
    public string ExiResponse { get; set; } = string.Empty;

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
