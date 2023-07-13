using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SecurityEventNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class SecurityEventNotificationRequest : RequestPayload
    {
        public string type = string.Empty;
        public DateTime timestamp;
        public string? techInfo;
        
    }
}