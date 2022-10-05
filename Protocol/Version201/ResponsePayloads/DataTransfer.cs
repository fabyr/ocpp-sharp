using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class DataTransfer : ResponsePayload
    {
        public DataTransferStatusType.Enum status;
        public object? data;
        public StatusInfo? statusInfo;
    }
}