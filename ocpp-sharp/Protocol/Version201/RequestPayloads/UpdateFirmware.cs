using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UpdateFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class UpdateFirmwareRequest : RequestPayload
{
    [JsonProperty("retries")]
    public int? Retries { get; set; }

    [JsonProperty("retryInterval")]
    public int? RetryInterval { get; set; }

    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("firmware")]
    public Firmware Firmware { get; set; }
}
