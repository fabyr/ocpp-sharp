using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingLimit
    {
        public static readonly ChargingLimit Empty = new ChargingLimit();

        public ChargingLimitSourceType.Enum chargingLimitSource;
        public bool? isGridCritical;
    }
}