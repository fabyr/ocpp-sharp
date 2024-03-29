using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ReserveNowRequest : RequestPayload
    {
        public ulong connectorId;
        public DateTime expiryDate;
        public CiString idTag = string.Empty;
        public CiString? parentIdTag;
        public long reservationId;

    }
}