using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct Component
    {
        public static readonly Component Empty = new Component();

        public CiString name;
        public CiString? instance;
        public EVSE? evse;
    }
}