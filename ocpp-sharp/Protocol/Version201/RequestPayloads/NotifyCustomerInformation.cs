using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyCustomerInformation", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyCustomerInformationRequest : RequestPayload
{
    [JsonProperty("data")]
    public string Data { get; set; } = string.Empty;

    [JsonProperty("tbc")]
    public bool? Tbc { get; set; }

    [JsonProperty("seqNo")]
    public int SeqNo { get; set; }

    [JsonProperty("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonProperty("requestId")]
    public long RequestId { get; set; }
}
