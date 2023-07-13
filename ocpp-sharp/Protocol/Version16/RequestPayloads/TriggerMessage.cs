using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "TriggerMessage", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class TriggerMessageRequest : RequestPayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.MessageTrigger"/>
        /// </summary>
        public MessageConstants.MessageTrigger.Enum requestedMessage;
        public ulong? connectorId; // must be > 0

    }
}