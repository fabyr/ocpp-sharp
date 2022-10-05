using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class ReserveNow : RequestPayload
    {
        public ulong connectorId;
        public DateTime expiryDate;
        public CiString idTag = string.Empty;
        public CiString? parentIdTag;
        public long reservationId;

    }
}