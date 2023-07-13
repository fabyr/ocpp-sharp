using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct ChargingSchedulePeriod
    {
        public static readonly ChargingSchedulePeriod Empty = new ChargingSchedulePeriod();

        public long startPeriod;
        public double limit;
        public long? numberPhases;
    }
}