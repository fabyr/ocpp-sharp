using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "CancelReservation", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class CancelReservationResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.CancelReservationStatus"/>
        /// </summary>
        public MessageConstants.CancelReservationStatus.Enum status;
    }
}