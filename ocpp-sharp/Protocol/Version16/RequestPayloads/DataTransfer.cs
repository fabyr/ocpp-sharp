using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferRequest : RequestPayload
{
    [JsonProperty("vendorId")]
    public CiString VendorId { get; set; } = string.Empty;

    [JsonProperty("messageId")]
    public CiString? MessageId { get; set; }

    [JsonProperty("data")]
    public string? Data { get; set; }
}
