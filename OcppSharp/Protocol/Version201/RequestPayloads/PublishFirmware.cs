using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "PublishFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class PublishFirmwareRequest : RequestPayload
{
    [JsonPropertyName("location")]
    public string Location { get; set; } = string.Empty;

    [JsonPropertyName("retries")]
    public int? Retries { get; set; }

    [JsonPropertyName("checksum")]
    public CiString Checksum { get; set; }  // md5

    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("retryInterval")]
    public int? RetryInterval { get; set; }
}
