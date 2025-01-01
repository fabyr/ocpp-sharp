using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "RemoteStopTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class RemoteStopTransactionResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="RemoteStartStopStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public RemoteStartStopStatus.Enum Status { get; set; }
}
