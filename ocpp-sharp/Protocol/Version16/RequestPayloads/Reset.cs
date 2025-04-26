using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Reset", OcppMessageAttribute.Direction.CentralToPoint)]
public class ResetRequest : RequestPayload
{
    /// <summary>
    /// Valid values in <see cref="ResetType"/>
    /// </summary>
    [JsonPropertyName("type")]
    public ResetType.Enum Type { get; set; }
}
