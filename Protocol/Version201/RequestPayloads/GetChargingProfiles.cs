using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetChargingProfiles", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetChargingProfilesRequest : RequestPayload
    {
        public long requestId;
        public long evseId;
        public ChargingProfileCriterion chargingProfile = ChargingProfileCriterion.Empty;

    }
}