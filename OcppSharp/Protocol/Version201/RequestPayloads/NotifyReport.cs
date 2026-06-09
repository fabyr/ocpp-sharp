using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyReport", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyReportRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonPropertyName("tbc")]
    public bool? Tbc { get; set; }

    [JsonPropertyName("seqNo")]
    public int SeqNo { get; set; }

    [JsonPropertyName("reportData")]
    public ReportData[]? ReportData { get; set; }
}
