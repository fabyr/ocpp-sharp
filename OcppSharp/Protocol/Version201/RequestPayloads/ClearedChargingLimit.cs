using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearedChargingLimit", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearedChargingLimitRequest : RequestPayload
{
    [JsonPropertyName("chargingLimitSource")]
    public ChargingLimitSourceType.Enum ChargingLimitSource { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }
}
