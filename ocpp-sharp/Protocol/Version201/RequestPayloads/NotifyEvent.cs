using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyEvent", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyEventRequest : RequestPayload
{
    [JsonProperty("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonProperty("tbc")]
    public bool? Tbc { get; set; }

    [JsonProperty("seqNo")]
    public int SeqNo { get; set; }

    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonProperty("eventData")]
    public EventData[] EventData { get; set; } = [];
}
