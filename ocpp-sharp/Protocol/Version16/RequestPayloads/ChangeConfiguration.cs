using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ChangeConfiguration", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ChangeConfigurationRequest : RequestPayload
    {
        public CiString key = string.Empty;
        public CiString value = string.Empty;

    }
}