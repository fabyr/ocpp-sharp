using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Heartbeat", OcppMessageAttribute.Direction.CentralToPoint)]
public class HeartbeatResponse : ResponsePayload
{
    [JsonPropertyName("currentTime")]
    public DateTime CurrentTime { get; set; }
}
