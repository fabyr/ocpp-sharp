using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyDisplayMessages", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyDisplayMessagesRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("tbc")]
    public bool? Tbc { get; set; }

    [JsonPropertyName("messageInfo")]
    public MessageInfo[]? MessageInfo { get; set; }
}
