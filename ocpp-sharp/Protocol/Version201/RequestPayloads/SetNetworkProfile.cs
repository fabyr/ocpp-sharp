using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetNetworkProfile", OcppMessageAttribute.Direction.CentralToPoint)]
    public class SetNetworkProfileRequest : RequestPayload
    {
        public int configurationSlot;
        public NetworkConnectionProfile connectionData;
        
    }
}