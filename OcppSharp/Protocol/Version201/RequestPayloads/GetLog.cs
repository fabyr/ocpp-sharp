using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetLog", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetLogRequest : RequestPayload
{
    [JsonPropertyName("logType")]
    public LogType.Enum LogType { get; set; }

    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("retries")]
    public int? Retries { get; set; }

    [JsonPropertyName("retryInterval")]
    public int? RetryInterval { get; set; }

    [JsonPropertyName("log")]
    public LogParameters Log { get; set; } = LogParameters.Empty;
}
