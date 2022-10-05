using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class MonitorType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(MonitorType.UpperThreshold)]
            UpperThreshold,
            [StringValue(MonitorType.LowerThreshold)]
            LowerThreshold,
            [StringValue(MonitorType.Delta)]
            Delta,
            [StringValue(MonitorType.Periodic)]
            Periodic,
            [StringValue(MonitorType.PeriodicClockAligned)]
            PeriodicClockAligned
        }
        public const string UpperThreshold = "UpperThreshold";
        public const string LowerThreshold = "LowerThreshold";
        public const string Delta = "Delta";
        public const string Periodic = "Periodic";
        public const string PeriodicClockAligned = "PeriodicClockAligned";
    }
}