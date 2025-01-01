using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetDiagnostics", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetDiagnosticsRequest : RequestPayload
{
    [JsonProperty("location")]
    public string Location { get; set; } = string.Empty;

    [JsonProperty("retries")]
    public long? Retries { get; set; }

    [JsonProperty("retryInterval")]
    public long? RetryInterval { get; set; }

    [JsonProperty("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonProperty("stopTime")]
    public DateTime? StopTime { get; set; }
}
