using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ClearCache", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ClearCacheRequest : RequestPayload
    {
    }
}