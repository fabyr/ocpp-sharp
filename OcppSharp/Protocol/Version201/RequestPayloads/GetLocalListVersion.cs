namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetLocalListVersion", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetLocalListVersionRequest : RequestPayload
{
}
