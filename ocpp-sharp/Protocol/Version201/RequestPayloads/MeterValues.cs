using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "MeterValues", OcppMessageAttribute.Direction.PointToCentral)]
public class MeterValuesRequest : RequestPayload
{
    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    /// <summary>
    /// Array must contain atleast one entry.
    /// </summary>
    [JsonProperty("meterValue")]
    public MeterValue[] MeterValue { get; set; } = [];
}
