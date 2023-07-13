using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct SetVariableData
    {
        public static readonly SetVariableData Empty = new SetVariableData();

        public AttributeType.Enum? attributeType;
        public string attributeValue;
        public Component component;
        public Variable variable;
    }
}