using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct Variable
    {
        public static readonly Variable Empty = new Variable();

        public CiString name;
        public CiString? instance;
    }
}