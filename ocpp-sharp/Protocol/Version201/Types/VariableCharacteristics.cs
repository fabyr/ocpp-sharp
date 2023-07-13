using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct VariableCharacteristics
    {
        public static readonly VariableCharacteristics Empty = new VariableCharacteristics();

        public CiString? unit;
        public DataType.Enum dataType;
        public double? minLimit;
        public double? maxLimit;
        public string? valuesList;
        public bool supportsMonitoring;
    }
}