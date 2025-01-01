namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "DiagnosticsStatusNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class DiagnosticsStatusNotificationResponse : ResponsePayload
{
}
