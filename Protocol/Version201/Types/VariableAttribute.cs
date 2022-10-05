using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct VariableAttribute
    {
        public static readonly VariableAttribute Empty = new VariableAttribute();

        public AttributeType.Enum? type;
        public string? value;
        public MutabilityType.Enum? mutability; // Default = MutabilityType.Enum.ReadWrite
    }
}