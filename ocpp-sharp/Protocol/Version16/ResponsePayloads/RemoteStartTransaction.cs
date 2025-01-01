using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "RemoteStartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class RemoteStartTransactionResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="RemoteStartStopStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public RemoteStartStopStatus.Enum Status { get; set; }
}
