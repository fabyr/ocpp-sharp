using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct SetMonitoringResult
    {
        public static readonly SetMonitoringResult Empty = new SetMonitoringResult();

        public int? id;
        public SetMonitoringStatusType.Enum status;
        public MonitorType.Enum type;
    }
}