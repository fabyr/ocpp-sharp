using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "UpdateFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class UpdateFirmwareRequest : RequestPayload
{
    [JsonProperty("location")]
    public string Location { get; set; } = string.Empty;

    [JsonProperty("retries")]
    public long? Retries { get; set; }

    [JsonProperty("retrieveDate")]
    public DateTime RetrieveDate { get; set; }

    [JsonProperty("retryInterval")]
    public long? RetryInterval { get; set; }
}
