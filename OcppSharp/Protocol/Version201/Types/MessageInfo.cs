using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct MessageInfo
{
    public static readonly MessageInfo Empty = new();

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("priority")]
    public MessagePriorityType.Enum Priority { get; set; }

    [JsonPropertyName("state")]
    public MessageStateType.Enum? State { get; set; }

    [JsonPropertyName("startDateTime")]
    public DateTime? StartDateTime { get; set; }

    [JsonPropertyName("endDateTime")]
    public DateTime? EndDateTime { get; set; }

    [JsonPropertyName("transactionId")]
    public CiString? TransactionId { get; set; }

    [JsonPropertyName("message")]
    public MessageContent Message { get; set; }
}
