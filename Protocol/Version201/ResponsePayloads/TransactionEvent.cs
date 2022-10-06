using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "TransactionEvent", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class TransactionEvent : ResponsePayload
    {
        public decimal? totalCost;
        public int? chargingPriority;
        public IdTokenInfo? idTokenInfo;
        public MessageContent? updatedPersonalMessage;
    }
}