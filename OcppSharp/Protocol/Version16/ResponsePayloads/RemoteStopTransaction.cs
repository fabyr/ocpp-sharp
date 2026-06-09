using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "RemoteStopTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class RemoteStopTransactionResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="RemoteStartStopStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public RemoteStartStopStatus.Enum Status { get; set; }
}
