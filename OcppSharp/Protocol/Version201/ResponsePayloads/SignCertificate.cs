using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SignCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
public class SignCertificateResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
