using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyDisplayMessages", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyDisplayMessagesRequest : RequestPayload
    {
        public long requestId;
        public bool? tbc;
        public MessageInfo[]? messageInfo;
        
    }
}