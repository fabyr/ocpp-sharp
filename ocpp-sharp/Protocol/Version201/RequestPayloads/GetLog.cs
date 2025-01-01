using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetLog", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetLogRequest : RequestPayload
{
    [JsonProperty("logType")]
    public LogType.Enum LogType { get; set; }

    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("retries")]
    public int? Retries { get; set; }

    [JsonProperty("retryInterval")]
    public int? RetryInterval { get; set; }

    [JsonProperty("log")]
    public LogParameters Log { get; set; } = LogParameters.Empty;
}
