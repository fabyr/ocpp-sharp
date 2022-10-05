using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "UnlockConnector", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class UnlockConnector : RequestPayload
    {
        public ulong connectorId; // mute be > 0

    }
}