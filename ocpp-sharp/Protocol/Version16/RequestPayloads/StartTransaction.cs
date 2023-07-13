using System;
using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
    public class StartTransactionRequest : RequestPayload
    {
        public long connectorId;
        public CiString idTag = string.Empty;
        public long meterStart;
        public long? reservationId;
        public DateTime timestamp;

    }
}