using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "Heartbeat", OcppMessageAttribute.Direction.CentralToPoint)]
public class HeartbeatResponse : ResponsePayload
{
    [JsonPropertyName("currentTime")]
    public DateTime CurrentTime { get; set; }
}
