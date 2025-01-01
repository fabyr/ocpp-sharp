namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "FirmwareStatusNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class FirmwareStatusNotificationResponse : ResponsePayload
{
}
