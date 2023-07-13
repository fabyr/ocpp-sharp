using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetLocalListVersion", OcppMessageAttribute.Direction.CentralToPoint)]
    public class GetLocalListVersionRequest : RequestPayload
    {
    }
}