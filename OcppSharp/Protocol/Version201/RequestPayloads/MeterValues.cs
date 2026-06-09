using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "MeterValues", OcppMessageAttribute.Direction.PointToCentral)]
public class MeterValuesRequest : RequestPayload
{
    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    /// <summary>
    /// Array must contain atleast one entry.
    /// </summary>
    [JsonPropertyName("meterValue")]
    public MeterValue[] MeterValue { get; set; } = [];
}
