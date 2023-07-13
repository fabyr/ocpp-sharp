using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "RequestStartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
    public class RequestStartTransactionResponse : ResponsePayload
    {
        public RequestStartStopStatusType.Enum status;
        public CiString? transactionId;
        public StatusInfo? statusInfo;
    }
}