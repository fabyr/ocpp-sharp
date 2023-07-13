using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingSchedulePeriod
    {
        public static readonly ChargingSchedulePeriod Empty = new ChargingSchedulePeriod();

        public long startPeriod;
        public double limit;
        public int? numberPhases;
        public int? phaseToUse;
    }
}