using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Reset", OcppMessageAttribute.Direction.CentralToPoint)]
public class ResetRequest : RequestPayload
{
    [JsonPropertyName("type")]
    public ResetType.Enum Type { get; set; }

    [JsonPropertyName("type")]
    public long? EvseId { get; set; }
}
