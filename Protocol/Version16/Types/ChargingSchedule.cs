using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct ChargingSchedule
    {
        public static readonly ChargingSchedule Empty = new ChargingSchedule();

        public long? duration;
        public DateTime? startSchedule;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ChargingRateUnitType"/>
        /// </summary>
        public MessageConstants.ChargingRateUnitType.Enum chargingRateUnit;
        public ChargingSchedulePeriod[] chargingSchedulePeriod;
        public double? minChargingRate;
    }
}