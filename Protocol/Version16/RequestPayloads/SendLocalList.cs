using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "SendLocalList", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class SendLocalListRequest : RequestPayload
    {
        public long listVersion;
        public AuthorizationData[]? localAuthorizationList;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.UpdateType"/>
        /// </summary>
        public MessageConstants.UpdateType.Enum updateType;

    }
}