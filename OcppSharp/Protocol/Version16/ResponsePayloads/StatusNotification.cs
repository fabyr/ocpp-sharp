namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "StatusNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class StatusNotificationResponse : ResponsePayload
{
}
