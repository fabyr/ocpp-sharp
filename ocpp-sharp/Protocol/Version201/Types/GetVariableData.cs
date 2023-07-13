using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct GetVariableData
    {
        public static readonly GetVariableData Empty = new GetVariableData();

        public AttributeType.Enum? attributeType;
        public Component component;
        public Variable variable;
    }
}