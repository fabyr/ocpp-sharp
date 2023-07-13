using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetChargingProfile", OcppMessageAttribute.Direction.CentralToPoint)]
    public class SetChargingProfileRequest : RequestPayload
    {
        public long evseId;
        public ChargingProfile chargingProfile;
        
    }
}