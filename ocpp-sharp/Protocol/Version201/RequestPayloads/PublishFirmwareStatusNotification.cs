using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "PublishFirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class PublishFirmwareStatusNotificationRequest : RequestPayload
    {
        public PublishFirmwareStatusType.Enum status;
        public string[]? location;
        public long? requestId;
        
    }
}