using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct SetVariableResult
    {
        public static readonly SetVariableResult Empty = new SetVariableResult();

        public AttributeType.Enum? attributeType;
        public SetVariableStatusType.Enum attributeStatus;
        public Component component;
        public Variable variable;
        public StatusInfo? attributeStatusInfo;
    }
}