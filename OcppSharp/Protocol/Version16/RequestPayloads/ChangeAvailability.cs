using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version16.MessageConstants;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ChangeAvailability", OcppMessageAttribute.Direction.CentralToPoint)]
public class ChangeAvailabilityRequest : RequestPayload
{
    [JsonPropertyName("connectorId")]
    public ulong ConnectorId { get; set; }

    /// <summary>
    /// Valid values in <see cref="AvailabilityType"/>
    /// </summary>
    [JsonPropertyName("type")]
    public AvailabilityType.Enum Type { get; set; }
}
