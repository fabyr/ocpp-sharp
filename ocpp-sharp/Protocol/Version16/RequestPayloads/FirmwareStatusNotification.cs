using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "FirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class FirmwareStatusNotificationRequest : RequestPayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.FirmwareStatus"/>
        /// </summary>
        public MessageConstants.FirmwareStatus.Enum status;

    }
}