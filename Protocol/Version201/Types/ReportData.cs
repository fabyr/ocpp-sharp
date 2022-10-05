using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ReportData
    {
        public static readonly ReportData Empty = new ReportData();

        public Component component;
        public Variable variable;

        /// <summary>
        /// Must contain atleast one entry.
        /// </summary>
        public VariableAttribute[] variableAttribute;
        
        public VariableCharacteristics? variableCharacteristics;
    }
}