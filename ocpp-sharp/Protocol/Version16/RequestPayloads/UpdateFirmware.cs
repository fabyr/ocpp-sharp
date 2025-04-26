using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "UpdateFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class UpdateFirmwareRequest : RequestPayload
{
    [JsonPropertyName("location")]
    public string Location { get; set; } = string.Empty;

    [JsonPropertyName("retries")]
    public long? Retries { get; set; }

    [JsonPropertyName("retrieveDate")]
    public DateTime RetrieveDate { get; set; }

    [JsonPropertyName("retryInterval")]
    public long? RetryInterval { get; set; }
}
