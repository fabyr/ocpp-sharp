using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "PublishFirmware", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class PublishFirmwareRequest : RequestPayload
    {
        public string location = string.Empty;
        public int? retries;
        public CiString checksum; // md5
        public long requestId;
        public int? retryInterval;

    }
}