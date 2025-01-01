namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearCache", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearCacheRequest : RequestPayload
{
}
