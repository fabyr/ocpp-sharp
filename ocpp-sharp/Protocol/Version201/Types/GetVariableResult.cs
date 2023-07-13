using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct GetVariableResult
    {
        public static readonly GetVariableResult Empty = new GetVariableResult();

        public GetVariableStatusType.Enum attributeStatus;
        public AttributeType.Enum? attributeType;
        public string? attributeValue;
        public Component component;
    }
}