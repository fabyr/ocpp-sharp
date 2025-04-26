using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyCustomerInformation", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyCustomerInformationRequest : RequestPayload
{
    [JsonPropertyName("data")]
    public string Data { get; set; } = string.Empty;

    [JsonPropertyName("tbc")]
    public bool? Tbc { get; set; }

    [JsonPropertyName("seqNo")]
    public int SeqNo { get; set; }

    [JsonPropertyName("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }
}
