using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ClearMonitoringResult
    {
        public static readonly ClearMonitoringResult Empty = new ClearMonitoringResult();

        public ClearMonitoringStatusType.Enum status;
        public long id;
        public StatusInfo? statusInfo;
    }
}