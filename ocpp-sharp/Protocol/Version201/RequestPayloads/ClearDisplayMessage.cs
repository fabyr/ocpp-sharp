using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearDisplayMessage", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearDisplayMessageRequest : RequestPayload
{
    [JsonProperty("id")]
    public long Id { get; set; }
}
