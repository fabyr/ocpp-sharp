using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ClearChargingProfile", OcppMessageAttribute.Direction.PointToCentral)]
    public class ClearChargingProfileResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ClearChargingProfileStatus"/>
        /// </summary>
        public MessageConstants.ClearChargingProfileStatus.Enum status;
    }
}