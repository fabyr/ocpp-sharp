using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ClearMonitoringStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ClearMonitoringStatusType.Accepted)]
        Accepted,

        [StringValue(ClearMonitoringStatusType.Rejected)]
        Rejected,

        [StringValue(ClearMonitoringStatusType.NotFound)]
        NotFound
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string NotFound = "NotFound";
}
