using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetDiagnostics", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetDiagnosticsRequest : RequestPayload
{
    [JsonPropertyName("location")]
    public string Location { get; set; } = string.Empty;

    [JsonPropertyName("retries")]
    public long? Retries { get; set; }

    [JsonPropertyName("retryInterval")]
    public long? RetryInterval { get; set; }

    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("stopTime")]
    public DateTime? StopTime { get; set; }
}
