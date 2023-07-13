using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ChangeAvailability", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ChangeAvailabilityRequest : RequestPayload
    {
        public ulong connectorId;
        
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.AvailabilityType"/>
        /// </summary>
        public MessageConstants.AvailabilityType.Enum type;

    }
}