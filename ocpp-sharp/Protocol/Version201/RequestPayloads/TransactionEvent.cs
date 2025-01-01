using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "TransactionEvent", OcppMessageAttribute.Direction.PointToCentral)]
public class TransactionEventRequest : RequestPayload
{
    [JsonProperty("eventType")]
    public TransactionEventType.Enum EventType { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("triggerReason")]
    public TriggerReasonType.Enum TriggerReason { get; set; }

    [JsonProperty("seqNo")]
    public int SeqNo { get; set; }

    [JsonProperty("offline")]
    public bool? Offline { get; set; }

    [JsonProperty("numberOfPhasesUsed")]
    public int? NumberOfPhasesUsed { get; set; }

    [JsonProperty("cableMaxCurrent")]
    public int? CableMaxCurrent { get; set; } // Unit is Ampere

    [JsonProperty("reservationId")]
    public int? ReservationId { get; set; }

    [JsonProperty("transactionInfo")]
    public Transaction TransactionInfo { get; set; }

    [JsonProperty("idToken")]
    public IdToken? IdToken { get; set; }

    [JsonProperty("evse")]
    public EVSE? Evse { get; set; }

    [JsonProperty("meterValue")]
    public MeterValue[]? MeterValue { get; set; }
}
