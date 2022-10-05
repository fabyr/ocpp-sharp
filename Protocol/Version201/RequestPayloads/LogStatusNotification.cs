using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "LogStatusNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class LogStatusNotification : RequestPayload
    {
        public UploadLogStatusType.Enum status;
        public long? requestId;

    }
}