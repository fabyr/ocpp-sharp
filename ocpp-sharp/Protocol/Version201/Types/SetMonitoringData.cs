using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct SetMonitoringData
    {
        public static readonly SetMonitoringData Empty = new SetMonitoringData();

        public int? id;
        public bool? transaction;
        public double value;
        public MonitorType.Enum type;
    }
}