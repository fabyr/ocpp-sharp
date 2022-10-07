using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "RequestStopTransaction", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class RequestStopTransactionRequest : RequestPayload
    {
        public CiString transactionId;
        
    }
}