using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "TriggerMessage", OcppMessageAttribute.Direction.CentralToPoint)]
    public class TriggerMessageRequest : RequestPayload
    {
        public MessageTriggerType.Enum requestedMessage;
        public EVSE? evse;
        
    }
}