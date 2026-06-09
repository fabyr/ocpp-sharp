namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Heartbeat", OcppMessageAttribute.Direction.PointToCentral)]
public class HeartbeatRequest : RequestPayload
{
}
