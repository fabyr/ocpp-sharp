using OcppSharp.Protocol.Version16.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "MeterValues", OcppMessageAttribute.Direction.PointToCentral)]
public class MeterValuesRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public ulong ConnectorId { get; set; }

    [JsonPropertyName("transactionId")]
    public long? TransactionId { get; set; }

    [JsonPropertyName("meterValue")]
    public MeterValue[] MeterValue { get; set; } = [];
}
