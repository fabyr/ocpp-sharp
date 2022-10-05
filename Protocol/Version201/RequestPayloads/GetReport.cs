using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetReport", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetReport : RequestPayload
    {
        public long requestId;

        /// <summary>
        /// Array length must not exceed 4.
        /// </summary>
        public ComponentCriterionType.Enum[]? componentCriteria;

        public ComponentVariable[]? componentVariable;

    }
}