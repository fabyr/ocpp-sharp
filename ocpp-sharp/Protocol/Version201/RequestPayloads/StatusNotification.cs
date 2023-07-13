using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "StatusNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class StatusNotificationRequest : RequestPayload
    {
        public DateTime timestamp;
        public ConnectorStatusType.Enum connectorStatus;
        public long evseId;
        public long connectorId;
        
    }
}