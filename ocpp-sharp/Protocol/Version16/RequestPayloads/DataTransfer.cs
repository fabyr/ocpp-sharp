using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    // Can be sent by both
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.PointToCentral)]
    public class DataTransferRequest : RequestPayload
    {
        public CiString vendorId = string.Empty;
        public CiString? messageId;

        public string? data;

    }
}