using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ClearCache", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ClearCache : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ClearCacheStatus"/>
        /// </summary>
        public MessageConstants.ClearCacheStatus.Enum status;
    }
}