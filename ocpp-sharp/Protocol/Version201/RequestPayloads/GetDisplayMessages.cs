using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetDisplayMessages", OcppMessageAttribute.Direction.CentralToPoint)]
    public class GetDisplayMessagesRequest : RequestPayload
    {
        public long[]? id;
        public long requestId;
        public MessagePriorityType.Enum priority;
        public MessageStateType.Enum state;

    }
}