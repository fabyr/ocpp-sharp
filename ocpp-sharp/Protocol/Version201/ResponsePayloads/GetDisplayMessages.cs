using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetDisplayMessages", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetDisplayMessagesResponse : ResponsePayload
    {
        public GetDisplayMessagesStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}