using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearChargingProfile", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ClearChargingProfileResponse : ResponsePayload
    {
        public ClearChargingProfileStatusType.Enum status;
        public StatusInfo? statusInfo;
    }
}