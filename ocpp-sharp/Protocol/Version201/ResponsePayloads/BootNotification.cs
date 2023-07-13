using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "BootNotification", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class BootNotificationResponse : ResponsePayload
    {
        public DateTime currentTime;
        public int interval;
        public RegistrationStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}