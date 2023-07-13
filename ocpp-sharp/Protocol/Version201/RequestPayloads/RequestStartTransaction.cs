using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "RequestStartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
    public class RequestStartTransactionRequest : RequestPayload
    {
        public long? evseId;
        public long remoteStartId;
        public IdToken idToken;
        public ChargingProfile? chargingProfile;
        public IdToken? groupIdToken;
        
    }
}