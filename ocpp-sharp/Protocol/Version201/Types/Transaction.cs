using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct Transaction
{
    public static readonly Transaction Empty = new();

    [JsonPropertyName("transactionId")]
    public CiString TransactionId { get; set; }

    [JsonPropertyName("chargingState")]
    public ChargingStateType.Enum? ChargingState { get; set; }

    [JsonPropertyName("timeSpentCharging")]
    public int? TimeSpentCharging { get; set; }

    [JsonPropertyName("stoppedReason")]
    public ReasonType.Enum? StoppedReason { get; set; }

    [JsonPropertyName("remoteStartId")]
    public long? RemoteStartId { get; set; }
}
