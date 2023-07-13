using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "StartTransaction", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class StartTransactionResponse : ResponsePayload
    {
        public IdTagInfo idTagInfo = IdTagInfo.Empty;
        public long transactionId;
    }
}