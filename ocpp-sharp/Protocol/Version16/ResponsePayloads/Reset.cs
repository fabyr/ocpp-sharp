using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "Reset", OcppMessageAttribute.Direction.PointToCentral)]
    public class ResetResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ResetStatus"/>
        /// </summary>
        public MessageConstants.ResetStatus.Enum status;
    }
}