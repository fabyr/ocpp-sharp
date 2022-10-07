using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetBaseReport", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class GetBaseReportResponse : ResponsePayload
    {
        public GenericDeviceModelStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}