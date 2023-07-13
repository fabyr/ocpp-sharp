using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StopTransaction", OcppMessageAttribute.Direction.PointToCentral)]
    public class StopTransactionRequest : RequestPayload
    {
        public CiString? idTag;
        public long meterStop;
        public DateTime timestamp;
        public long transactionId;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.Reason"/>
        /// </summary>
        public MessageConstants.Reason.Enum? reason;
        public MeterValue[]? transactionData;

    }
}