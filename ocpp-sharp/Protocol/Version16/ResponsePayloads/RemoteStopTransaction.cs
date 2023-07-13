using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "RemoteStopTransaction", OcppMessageAttribute.Direction.PointToCentral)]
    public class RemoteStopTransactionResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.RemoteStartStopStatus"/>
        /// </summary>
        public MessageConstants.RemoteStartStopStatus.Enum status;
    }
}