using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEvent", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyEventRequest : RequestPayload
    {
        public DateTime generatedAt;
        public bool? tbc;
        public int seqNo;

        /// <summary>
        /// Must contain atleast one element.
        /// </summary>
        public EventData[] eventData = new EventData[0];

    }
}