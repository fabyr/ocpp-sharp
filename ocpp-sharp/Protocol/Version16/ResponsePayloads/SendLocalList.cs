using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "SendLocalList", OcppMessageAttribute.Direction.PointToCentral)]
public class SendLocalListResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="UpdateStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public UpdateStatus.Enum Status { get; set; }
}
