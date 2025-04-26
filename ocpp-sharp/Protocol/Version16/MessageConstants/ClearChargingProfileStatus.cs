using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ClearChargingProfileStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ClearChargingProfileStatus.Accepted)]
        Accepted,

        [StringValue(ClearChargingProfileStatus.Unknown)]
        Unknown
    }

    public const string Accepted = "Accepted";
    public const string Unknown = "Unknown";
}
