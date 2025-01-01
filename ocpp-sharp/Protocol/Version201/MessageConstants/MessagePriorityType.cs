using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class MessagePriorityType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(MessagePriorityType.AlwaysFront)]
        AlwaysFront,

        [StringValue(MessagePriorityType.InFront)]
        InFront,

        [StringValue(MessagePriorityType.NormalCycle)]
        NormalCycle
    }

    public const string AlwaysFront = "AlwaysFront";
    public const string InFront = "InFront";
    public const string NormalCycle = "NormalCycle";
}
