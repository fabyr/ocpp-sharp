using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StopTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class StopTransactionRequest : RequestPayload
{
    [JsonPropertyName("idTag")]
    public CiString? IdTag { get; set; }

    [JsonPropertyName("meterStop")]
    public long MeterStop { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("transactionId")]
    public long TransactionId { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Reason"/>
    /// </summary>
    [JsonPropertyName("reason")]
    public Reason.Enum? Reason { get; set; }

    [JsonPropertyName("transactionData")]
    public MeterValue[]? TransactionData { get; set; }
}
