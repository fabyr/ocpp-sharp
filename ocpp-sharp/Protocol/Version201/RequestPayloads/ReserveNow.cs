using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ReserveNowRequest : RequestPayload
    {
        public long id;
        public DateTime expiryDateTime;
        public ConnectorType.Enum connectorType;
        public long evseId;
        public IdToken idToken;
        public IdToken groupIdToken;
        
    }
}