using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "SetChargingProfile", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class SetChargingProfileRequest : RequestPayload
    {
        public long connectorId;
        public ChargingProfile csChargingProfiles = ChargingProfile.Empty;

    }
}