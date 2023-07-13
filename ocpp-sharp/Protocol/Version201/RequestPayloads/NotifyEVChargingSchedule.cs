using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEVChargingSchedule", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyEVChargingScheduleRequest : RequestPayload
    {
        public DateTime timeBase;
        public long evseId;
        public ChargingSchedule chargingSchedule;

    }
}