using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetReport", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetReportResponse : ResponsePayload
    {
        public GenericDeviceModelStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}