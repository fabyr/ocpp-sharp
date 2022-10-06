using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "TransactionEvent", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class TransactionEvent : RequestPayload
    {
        public TransactionEventType.Enum eventType;
        public DateTime timestamp;
        public TriggerReasonType.Enum triggerReason;
        public int seqNo;
        public bool? offline;
        public int? numberOfPhasesUsed;
        public int? cableMaxCurrent; // Unit is Ampere
        public int? reservationId;
        public Transaction transactionInfo;
        public IdToken? idToken;
        public EVSE? evse;
        public MeterValue[]? meterValue;
    }
}