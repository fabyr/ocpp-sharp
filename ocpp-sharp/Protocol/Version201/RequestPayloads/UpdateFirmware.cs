using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UpdateFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class UpdateFirmwareRequest : RequestPayload
{
    [JsonPropertyName("retries")]
    public int? Retries { get; set; }

    [JsonPropertyName("retryInterval")]
    public int? RetryInterval { get; set; }

    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("firmware")]
    public Firmware Firmware { get; set; }
}
