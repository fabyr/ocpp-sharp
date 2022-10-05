using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct CompositeSchedule
    {
        public static readonly CompositeSchedule Empty = new CompositeSchedule();

        public long evseId;
        public int duration;
        public DateTime scheduleStart;
        public ChargingRateUnitType.Enum chargingRateUnit;

        /// <summary>
        /// Must be at least one.
        /// </summary>
        public ChargingSchedulePeriod[] chargingSchedulePeriod;
    }
}