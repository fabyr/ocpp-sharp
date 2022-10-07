using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "BootNotification", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class BootNotificationRequest : RequestPayload
    {
        public BootReasonType.Enum reason;
        public ChargingStation chargingStation = ChargingStation.Empty;

    }
}