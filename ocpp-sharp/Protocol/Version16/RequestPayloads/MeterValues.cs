using OcppSharp.Protocol.Version16.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "MeterValues", OcppMessageAttribute.Direction.PointToCentral)]
public class MeterValuesRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public ulong ConnectorId { get; set; }

    [JsonProperty("transactionId")]
    public long? TransactionId { get; set; }

    [JsonProperty("meterValue")]
    public MeterValue[] MeterValue { get; set; } = [];
}
