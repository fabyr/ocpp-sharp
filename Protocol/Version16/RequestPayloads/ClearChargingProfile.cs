using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ClearChargingProfile", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class ClearChargingProfile : RequestPayload
    {
        public long? id;
        public long? connectorId;
        
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ChargingProfilePurposeType"/>
        /// </summary>
        public MessageConstants.ChargingProfilePurposeType.Enum? chargingProfilePurpose;
        
        public long? stackLevel;
    }
}