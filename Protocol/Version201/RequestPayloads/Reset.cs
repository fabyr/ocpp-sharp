using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Reset", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class Reset : RequestPayload
    {
        public ResetType.Enum type;
        public long? evseId;
        
    }
}