using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetMonitoringLevel", OcppMessageAttribute.Direction.PointToCentral)]
    public class SetMonitoringLevelResponse : ResponsePayload
    {
        public GenericStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}