using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class RequestStartStopStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(RequestStartStopStatusType.Accepted)]
        Accepted,

        [StringValue(RequestStartStopStatusType.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
