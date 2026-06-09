using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "TriggerMessage", OcppMessageAttribute.Direction.PointToCentral)]
public class TriggerMessageResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="TriggerMessageStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public TriggerMessageStatus.Enum Status { get; set; }
}
