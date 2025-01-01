using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Get15118EVCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
public class Get15118EVCertificateRequest : RequestPayload
{
    [JsonProperty("iso15118SchemaVersion")]
    public string Iso15118SchemaVersion { get; set; } = string.Empty;

    [JsonProperty("action")]
    public CertificateActionType.Enum Action { get; set; }

    [JsonProperty("exiRequest")]
    public string ExiRequest { get; set; } = string.Empty;
}
