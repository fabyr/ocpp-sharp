using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ChangeAvailability", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ChangeAvailabilityResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.AvailabilityStatus"/>
        /// </summary>
        public MessageConstants.AvailabilityStatus.Enum status;
    }
}