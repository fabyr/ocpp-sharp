using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct EVSE
    {
        public static readonly EVSE Empty = new EVSE();

        public ulong id;
        public long connectorId;
    }
}