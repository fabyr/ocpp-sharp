using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ChangeConfiguration", OcppMessageAttribute.Direction.CentralToPoint)]
public class ChangeConfigurationRequest : RequestPayload
{
    [JsonPropertyName("key")]
    public CiString Key { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public CiString Value { get; set; } = string.Empty;
}
