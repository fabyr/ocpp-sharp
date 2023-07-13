using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEVChargingNeeds", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyEVChargingNeedsRequest : RequestPayload
    {
        public int? maxScheduleTuples;
        public long evseId;
        public ChargingNeeds chargingNeeds;

    }
}