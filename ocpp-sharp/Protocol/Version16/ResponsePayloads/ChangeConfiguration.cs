using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ChangeConfiguration", OcppMessageAttribute.Direction.PointToCentral)]
    public class ChangeConfigurationResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ConfigurationStatus"/>
        /// </summary>
        public MessageConstants.ConfigurationStatus.Enum status;
    }
}