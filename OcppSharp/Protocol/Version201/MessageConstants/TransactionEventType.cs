using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class TransactionEventType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(TransactionEventType.Ended)]
        Ended,

        [StringValue(TransactionEventType.Started)]
        Started,

        [StringValue(TransactionEventType.Updated)]
        Updated
    }

    public const string Ended = "Ended";
    public const string Started = "Started";
    public const string Updated = "Updated";
}
