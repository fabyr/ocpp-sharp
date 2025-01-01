using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "StartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class StartTransactionRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public long ConnectorId { get; set; }

    [JsonProperty("idTag")]
    public CiString IdTag { get; set; } = string.Empty;

    [JsonProperty("meterStart")]
    public long MeterStart { get; set; }

    [JsonProperty("reservationId")]
    public long? ReservationId { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }
}
