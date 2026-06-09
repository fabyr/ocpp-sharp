using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class StartTransactionRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public long ConnectorId { get; set; }

    [JsonPropertyName("idTag")]
    public CiString IdTag { get; set; } = string.Empty;

    [JsonPropertyName("meterStart")]
    public long MeterStart { get; set; }

    [JsonPropertyName("reservationId")]
    public long? ReservationId { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }
}
