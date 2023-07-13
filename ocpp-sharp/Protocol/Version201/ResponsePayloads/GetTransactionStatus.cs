using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetTransactionStatus", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetTransactionStatusResponse : ResponsePayload
    {
        public bool? ongoingIndicator;
        public bool messagesInQueue;
    }
}