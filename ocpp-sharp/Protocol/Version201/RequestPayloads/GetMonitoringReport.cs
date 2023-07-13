using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetMonitoringReport", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetMonitoringReportRequest : RequestPayload
    {
        public long requestId;

        /// <summary>
        /// Array length must not exceed 3.
        /// </summary>
        public MonitoringCriterionType.Enum[]? monitoringCriteria;

        public ComponentVariable[]? componentVariable;

    }
}