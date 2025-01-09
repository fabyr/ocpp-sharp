using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferRequest : RequestPayload
{
    [JsonProperty("messageId")]
    public string MessageId { get; set; } = string.Empty;

    [JsonProperty("data")]
    public object? Data { get; set; }

    [JsonProperty("vendorId")]
    public string VendorId { get; set; } = string.Empty;
}
