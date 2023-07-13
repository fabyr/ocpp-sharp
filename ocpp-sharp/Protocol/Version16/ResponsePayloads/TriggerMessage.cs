using System;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "TriggerMessage", OcppMessageAttribute.Direction.PointToCentral)]
    public class TriggerMessageResponse : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.TriggerMessageStatus"/>
        /// </summary>
        public MessageConstants.TriggerMessageStatus.Enum status;
    }
}