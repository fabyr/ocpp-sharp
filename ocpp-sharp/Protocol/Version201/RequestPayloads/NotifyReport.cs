using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyReport", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyReportRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonProperty("tbc")]
    public bool? Tbc { get; set; }

    [JsonProperty("seqNo")]
    public int SeqNo { get; set; }

    [JsonProperty("reportData")]
    public ReportData[]? ReportData { get; set; }
}
