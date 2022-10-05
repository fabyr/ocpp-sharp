using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetLog", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetLog : RequestPayload
    {
        public LogType.Enum logType;
        public long requestId;
        public int? retries;
        public int? retryInterval;
        public LogParameters log = LogParameters.Empty;

    }
}