namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "NotifyEvent", OcppMessageAttribute.Direction.CentralToPoint)]
public class NotifyEventResponse : ResponsePayload
{
}
