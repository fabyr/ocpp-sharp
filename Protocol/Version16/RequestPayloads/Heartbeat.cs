using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Heartbeat", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class Heartbeat : RequestPayload
    {
    }
}