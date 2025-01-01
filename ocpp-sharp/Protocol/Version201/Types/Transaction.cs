using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct Transaction
{
    public static readonly Transaction Empty = new();

    [JsonProperty("transactionId")]
    public CiString TransactionId { get; set; }

    [JsonProperty("chargingState")]
    public ChargingStateType.Enum? ChargingState { get; set; }

    [JsonProperty("timeSpentCharging")]
    public int? TimeSpentCharging { get; set; }

    [JsonProperty("stoppedReason")]
    public ReasonType.Enum? StoppedReason { get; set; }

    [JsonProperty("remoteStartId")]
    public long? RemoteStartId { get; set; }
}
