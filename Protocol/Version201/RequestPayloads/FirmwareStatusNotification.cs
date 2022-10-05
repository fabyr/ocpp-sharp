using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "FirmwareStatusNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class FirmwareStatusNotification : RequestPayload
    {
        public FirmwareStatusType.Enum status;
        public long requestId;

    }
}