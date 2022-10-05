using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "CancelReservation", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class CancelReservation : RequestPayload
    {
        public long reservationId;

    }
}