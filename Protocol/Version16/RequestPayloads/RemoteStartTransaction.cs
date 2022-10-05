using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "RemoteStartTransaction", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class RemoteStartTransaction : RequestPayload
    {
        public long? connectorId;
        public CiString idTag = string.Empty;
        public ChargingProfile? chargingProfile;

    }
}