using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearCache", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ClearCacheResponse : ResponsePayload
    {
        public ClearCacheStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}