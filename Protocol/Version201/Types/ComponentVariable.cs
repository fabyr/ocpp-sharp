using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ComponentVariable
    {
        public static readonly ComponentVariable Empty = new ComponentVariable();

        public Component component;
        public Variable? variable;
    }
}