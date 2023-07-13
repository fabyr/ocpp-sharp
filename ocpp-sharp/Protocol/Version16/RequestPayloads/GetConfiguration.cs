using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetConfiguration", OcppMessageAttribute.Direction.CentralToPoint)]
    public class GetConfigurationRequest : RequestPayload
    {
        public CiString[]? key;

    }
}