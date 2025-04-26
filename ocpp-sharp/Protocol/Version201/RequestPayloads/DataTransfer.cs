using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferRequest : RequestPayload
{
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; } = string.Empty;

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("vendorId")]
    public string VendorId { get; set; } = string.Empty;
}
