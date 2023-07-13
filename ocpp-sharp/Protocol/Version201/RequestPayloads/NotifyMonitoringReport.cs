using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyMonitoringReport", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyMonitoringReportRequest : RequestPayload
    {
        public long requestId;
        public bool? tbc;
        public int seqNo;
        public DateTime generatedAt;
        public MonitoringData[]? monitor;

    }
}