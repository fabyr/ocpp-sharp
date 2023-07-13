using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingSchedule
    {
        public static readonly ChargingSchedule Empty = new ChargingSchedule();

        public long id;
        public DateTime? startSchedule;
        public int? duration;
    }
}