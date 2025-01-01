using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

// Can be sent by both
[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "DataTransfer", OcppMessageAttribute.Direction.PointToCentral)]
public class DataTransferRequest : RequestPayload
{
    [JsonProperty("vendorId")]
    public CiString VendorId { get; set; } = string.Empty;

    [JsonProperty("messageId")]
    public CiString? MessageId { get; set; }

    [JsonProperty("data")]
    public string? Data { get; set; }
}
