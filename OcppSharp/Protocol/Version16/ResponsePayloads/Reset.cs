using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "Reset", OcppMessageAttribute.Direction.PointToCentral)]
public class ResetResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ResetStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public ResetStatus.Enum Status { get; set; }
}
