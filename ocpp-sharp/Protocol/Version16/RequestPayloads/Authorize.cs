using System;
using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Authorize", OcppMessageAttribute.Direction.PointToCentral)]
    public class AuthorizeRequest : RequestPayload
    {
        public CiString idTag = string.Empty;
    }
}