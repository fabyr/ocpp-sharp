using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "MeterValues", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class MeterValuesRequest : RequestPayload
    {
        public ulong connectorId;
        public long? transactionId;
        public MeterValue[] meterValue = new MeterValue[0];

    }
}