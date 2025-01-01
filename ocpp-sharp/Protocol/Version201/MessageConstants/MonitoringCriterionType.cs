using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class MonitoringCriterionType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(MonitoringCriterionType.ThresholdMonitoring)]
        ThresholdMonitoring,

        [StringValue(MonitoringCriterionType.DeltaMonitoring)]
        DeltaMonitoring,

        [StringValue(MonitoringCriterionType.PeriodicMonitoring)]
        PeriodicMonitoring
    }

    public const string ThresholdMonitoring = "ThresholdMonitoring";
    public const string DeltaMonitoring = "DeltaMonitoring";
    public const string PeriodicMonitoring = "PeriodicMonitoring";
}

