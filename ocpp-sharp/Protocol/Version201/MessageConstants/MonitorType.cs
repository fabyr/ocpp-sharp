using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class MonitorType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
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
