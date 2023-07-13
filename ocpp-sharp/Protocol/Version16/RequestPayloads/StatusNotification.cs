using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StatusNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class StatusNotificationRequest : RequestPayload
    {
        public ulong connectorId;
        public CiString errorCode = string.Empty;
        public CiString? info;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ChargePointStatus"/>
        /// </summary>
        public MessageConstants.ChargePointStatus.Enum status;
        public DateTime? timestamp;

    }
}