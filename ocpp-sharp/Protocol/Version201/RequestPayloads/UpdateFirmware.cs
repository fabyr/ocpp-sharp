using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UpdateFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
    public class UpdateFirmwareRequest : RequestPayload
    {
        public int? retries;
        public int? retryInterval;
        public long requestId;
        public Firmware firmware;
    }
}