using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetCompositeSchedule", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetCompositeScheduleResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.GetCompositeScheduleStatus"/>
        /// </summary>
        public MessageConstants.GetCompositeScheduleStatus.Enum status;
        public long? connectorId;
        public DateTime? scheduleStart;
        public ChargingSchedule? chargingSchedule;
    }
}