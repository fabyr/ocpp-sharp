using System;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "UnlockConnector", OcppMessageAttribute.Direction.PointToCentral)]
    public class UnlockConnectorResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.UnlockStatus"/>
        /// </summary>
        public MessageConstants.UnlockStatus.Enum status;
    }
}