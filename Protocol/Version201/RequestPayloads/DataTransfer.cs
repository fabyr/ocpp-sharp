using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class DataTransfer : RequestPayload
    {
        public string messageId = string.Empty;
        public object? data;
        public string vendorId = string.Empty;

    }
}