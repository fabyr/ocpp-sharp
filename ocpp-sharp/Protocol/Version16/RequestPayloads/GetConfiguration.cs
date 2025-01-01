using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetConfiguration", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetConfigurationRequest : RequestPayload
{
    [JsonProperty("key")]
    public CiString[]? Key { get; set; }
}
