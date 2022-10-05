using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ReportChargingProfiles", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ReportChargingProfiles : RequestPayload
    {
        public long requestId;
        public ChargingLimitSourceType.Enum chargingLimitSource;
        public bool? tbc;
        public long evseId;

        /// <summary>
        /// Must contain atleast one element
        /// </summary>
        public ChargingProfile[] chargingProfile = new ChargingProfile[0];
        
    }
}