using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyDisplayMessages", OcppMessageAttribute.Direction.PointToCentral)]
public class NotifyDisplayMessagesRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("tbc")]
    public bool? Tbc { get; set; }

    [JsonProperty("messageInfo")]
    public MessageInfo[]? MessageInfo { get; set; }
}
