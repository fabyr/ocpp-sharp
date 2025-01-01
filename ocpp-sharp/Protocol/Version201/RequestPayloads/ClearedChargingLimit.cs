using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearedChargingLimit", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearedChargingLimitRequest : RequestPayload
{
    [JsonProperty("chargingLimitSource")]
    public ChargingLimitSourceType.Enum ChargingLimitSource { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }
}
