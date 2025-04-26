using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "UnlockConnector", OcppMessageAttribute.Direction.PointToCentral)]
public class UnlockConnectorResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="UnlockStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public UnlockStatus.Enum Status { get; set; }
}
