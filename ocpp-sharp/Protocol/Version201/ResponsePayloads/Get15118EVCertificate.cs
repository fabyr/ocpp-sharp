using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Get15118EVCertificate", OcppMessageAttribute.Direction.PointToCentral)]
public class Get15118EVCertificateResponse : ResponsePayload
{
    [JsonProperty("status")]
    public Iso15118EVCertificateStatusType.Enum Status { get; set; }

    [JsonProperty("exiResponse")]
    public string ExiResponse { get; set; } = string.Empty;

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
