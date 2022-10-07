using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearDisplayMessage", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ClearDisplayMessageResponse : ResponsePayload
    {
        public ClearMessageStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}