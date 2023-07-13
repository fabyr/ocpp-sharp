using System;
using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "BootNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class BootNotificationRequest : RequestPayload
    {
        public CiString? chargeBoxSerialNumber;
        public CiString chargePointModel = string.Empty;
        public CiString? chargePointSerialNumber;
        public CiString chargePointVendor = string.Empty;
        public CiString? firmwareVersion;
        public CiString? iccid;
        public CiString? imsi;
        public CiString? meterSerialNumber;
        public CiString? meterType;

    }
}