using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct VariableMonitoring
    {
        public static readonly VariableMonitoring Empty = new VariableMonitoring();

        public long id;
        public bool transaction;
        public double value;
        public MonitorType.Enum type;
        public int severity;
    }
}