using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct MessageInfo
{
    public static readonly MessageInfo Empty = new();

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("priority")]
    public MessagePriorityType.Enum Priority { get; set; }

    [JsonProperty("state")]
    public MessageStateType.Enum? State { get; set; }

    [JsonProperty("startDateTime")]
    public DateTime? StartDateTime { get; set; }

    [JsonProperty("endDateTime")]
    public DateTime? EndDateTime { get; set; }

    [JsonProperty("transactionId")]
    public CiString? TransactionId { get; set; }

    [JsonProperty("message")]
    public MessageContent Message { get; set; }
}
