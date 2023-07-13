using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetCompositeSchedule", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetCompositeScheduleRequest : RequestPayload
    {
        public int duration;
        public ChargingRateUnitType.Enum? chargingRateUnit;
        public long evseId;

    }
}