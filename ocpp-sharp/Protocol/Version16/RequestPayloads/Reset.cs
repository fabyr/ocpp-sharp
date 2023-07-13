using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Reset", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ResetRequest : RequestPayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ResetType"/>
        /// </summary>
        public MessageConstants.ResetType.Enum type;

    }
}