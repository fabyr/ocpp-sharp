using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class MessageStateType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(MessageStateType.Charging)]
        Charging,

        [StringValue(MessageStateType.Faulted)]
        Faulted,

        [StringValue(MessageStateType.Idle)]
        Idle,

        [StringValue(MessageStateType.Unavailable)]
        Unavailable
    }

    public const string Charging = "Charging";
    public const string Faulted = "Faulted";
    public const string Idle = "Idle";
    public const string Unavailable = "Unavailable";
}
