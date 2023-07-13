using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "CancelReservation", OcppMessageAttribute.Direction.PointToCentral)]
    public class CancelReservationResponse : ResponsePayload
    {
        public CancelReservationStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}