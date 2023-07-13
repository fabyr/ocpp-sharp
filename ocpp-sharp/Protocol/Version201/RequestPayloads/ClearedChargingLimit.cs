using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearedChargingLimit", OcppMessageAttribute.Direction.PointToCentral)]
    public class ClearedChargingLimitRequest : RequestPayload
    {
        public ChargingLimitSourceType.Enum chargingLimitSource;
        public long evseId;

    }
}