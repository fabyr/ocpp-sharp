namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Heartbeat", OcppMessageAttribute.Direction.PointToCentral)]
public class HeartbeatRequest : RequestPayload
{
}
