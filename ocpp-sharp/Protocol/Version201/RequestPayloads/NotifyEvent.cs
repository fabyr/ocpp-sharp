using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEvent", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyEventRequest : RequestPayload
{
    [JsonPropertyName("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonPropertyName("tbc")]
    public bool? Tbc { get; set; }

    [JsonPropertyName("seqNo")]
    public int SeqNo { get; set; }

    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonPropertyName("eventData")]
    public EventData[] EventData { get; set; } = [];
}
