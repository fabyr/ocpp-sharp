using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetCompositeSchedule", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetCompositeScheduleResponse : ResponsePayload
    {
        public GenericStatusType.Enum status;
        public CompositeSchedule schedule;
        public StatusInfo? statusInfo;
    }
}