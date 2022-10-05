using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyReport", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class NotifyReport : RequestPayload
    {
        public long requestId;
        public DateTime generatedAt;
        public bool? tbc;
        public int seqNo;
        public ReportData[]? reportData;
        
    }
}