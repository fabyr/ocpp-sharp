using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class SetNetworkProfileStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(SetNetworkProfileStatusType.Accepted)]
        Accepted,

        [StringValue(SetNetworkProfileStatusType.Rejected)]
        Rejected,

        [StringValue(SetNetworkProfileStatusType.Failed)]
        Failed
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string Failed = "Failed";
}
