using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StopTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class StopTransactionRequest : RequestPayload
{
    [JsonProperty("idTag")]
    public CiString? IdTag { get; set; }

    [JsonProperty("meterStop")]
    public long MeterStop { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("transactionId")]
    public long TransactionId { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Reason"/>
    /// </summary>
    [JsonProperty("reason")]
    public Reason.Enum? Reason { get; set; }

    [JsonProperty("transactionData")]
    public MeterValue[]? TransactionData { get; set; }
}
