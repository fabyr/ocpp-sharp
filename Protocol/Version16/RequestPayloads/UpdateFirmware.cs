using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "UpdateFirmware", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class UpdateFirmware : RequestPayload
    {
        public string location = string.Empty;
        public long? retries;
        public DateTime retrieveDate;
        public long? retryInterval;

    }
}