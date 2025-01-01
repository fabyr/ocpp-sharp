using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "Heartbeat", OcppMessageAttribute.Direction.CentralToPoint)]
public class HeartbeatResponse : ResponsePayload
{
    [JsonProperty("currentTime")]
    public DateTime CurrentTime { get; set; }
}
