using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "TransactionEvent", OcppMessageAttribute.Direction.PointToCentral)]
public class TransactionEventRequest : RequestPayload
{
    [JsonPropertyName("eventType")]
    public TransactionEventType.Enum EventType { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("triggerReason")]
    public TriggerReasonType.Enum TriggerReason { get; set; }

    [JsonPropertyName("seqNo")]
    public int SeqNo { get; set; }

    [JsonPropertyName("offline")]
    public bool? Offline { get; set; }

    [JsonPropertyName("numberOfPhasesUsed")]
    public int? NumberOfPhasesUsed { get; set; }

    [JsonPropertyName("cableMaxCurrent")]
    public int? CableMaxCurrent { get; set; } // Unit is Ampere

    [JsonPropertyName("reservationId")]
    public int? ReservationId { get; set; }

    [JsonPropertyName("transactionInfo")]
    public Transaction TransactionInfo { get; set; }

    [JsonPropertyName("idToken")]
    public IdToken? IdToken { get; set; }

    [JsonPropertyName("evse")]
    public EVSE? Evse { get; set; }

    [JsonPropertyName("meterValue")]
    public MeterValue[]? MeterValue { get; set; }
}
