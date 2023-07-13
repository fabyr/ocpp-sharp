using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct MonitoringData
    {
        public static readonly MonitoringData Empty = new MonitoringData();

        public Component component;
        public Variable variable;

        /// <summary>
        /// Must contain atleast one element.
        /// </summary>
        public VariableMonitoring[] variableMonitoring;
    }
}