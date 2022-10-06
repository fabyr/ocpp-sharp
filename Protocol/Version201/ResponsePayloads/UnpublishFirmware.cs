using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "UnpublishFirmware", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class UnpublishFirmware : ResponsePayload
    {
        public UnpublishFirmwareStatusType.Enum status;
    }
}