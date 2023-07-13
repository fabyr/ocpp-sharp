using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    // Can be received by both
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.PointToCentral)]
    public class DataTransferResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.DataTransferStatus"/>
        /// </summary>
        public MessageConstants.DataTransferStatus.Enum status;
        public string? data;
    }
}