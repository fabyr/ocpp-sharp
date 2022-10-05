using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "Authorize", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class Authorize : ResponsePayload
    {
        public IdTagInfo idTagInfo = IdTagInfo.Empty;
    }
}