namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SecurityEventNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class SecurityEventNotificationResponse : ResponsePayload
{
}
