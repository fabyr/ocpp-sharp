using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DiagnosticsStatusNotification", OcppMessageAttribute.Direction.PointToCentral)]
    public class DiagnosticsStatusNotificationRequest : RequestPayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.DiagnosticsStatus"/>
        /// </summary>
        public MessageConstants.DiagnosticsStatus.Enum status;

    }
}