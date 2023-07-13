using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ReserveNow", OcppMessageAttribute.Direction.PointToCentral)]
    public class ReserveNowResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ReservationStatus"/>
        /// </summary>
        public MessageConstants.ReservationStatus.Enum status;
    }
}