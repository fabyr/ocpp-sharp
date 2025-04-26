using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferRequest : RequestPayload
{
    [JsonPropertyName("vendorId")]
    public CiString VendorId { get; set; } = string.Empty;

    [JsonPropertyName("messageId")]
    public CiString? MessageId { get; set; }

    [JsonPropertyName("data")]
    public string? Data { get; set; }
}
