using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "PublishFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class PublishFirmwareRequest : RequestPayload
{
    [JsonProperty("location")]
    public string Location { get; set; } = string.Empty;

    [JsonProperty("retries")]
    public int? Retries { get; set; }

    [JsonProperty("checksum")]
    public CiString Checksum { get; set; }  // md5

    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("retryInterval")]
    public int? RetryInterval { get; set; }
}
