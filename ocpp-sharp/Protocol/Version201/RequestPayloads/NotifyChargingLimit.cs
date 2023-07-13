using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyChargingLimit", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyChargingLimitRequest : RequestPayload
    {
        public long? evseId;
        public ChargingLimit chargingLimit = ChargingLimit.Empty;
        public ChargingSchedule[]? chargingSchedule;
        
    }
}