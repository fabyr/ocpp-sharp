using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SendLocalList", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class SendLocalListRequest : RequestPayload
    {
        public int versionNumber;
        public UpdateType.Enum updateType;
        public AuthorizationData[]? localAuthorizationList;
        
    }
}