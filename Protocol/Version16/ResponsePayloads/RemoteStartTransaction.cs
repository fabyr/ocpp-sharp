using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "RemoteStartTransaction", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class RemoteStartTransactionResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.RemoteStartStopStatus"/>
        /// </summary>
        public MessageConstants.RemoteStartStopStatus.Enum status;
    }
}