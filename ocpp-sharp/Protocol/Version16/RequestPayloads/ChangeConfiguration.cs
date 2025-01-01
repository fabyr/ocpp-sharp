using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ChangeConfiguration", OcppMessageAttribute.Direction.CentralToPoint)]
public class ChangeConfigurationRequest : RequestPayload
{
    [JsonProperty("key")]
    public CiString Key { get; set; } = string.Empty;

    [JsonProperty("value")]
    public CiString Value { get; set; } = string.Empty;
}
