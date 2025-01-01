using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "ChangeAvailability", OcppMessageAttribute.Direction.CentralToPoint)]
public class ChangeAvailabilityRequest : RequestPayload
{
    [JsonProperty("connectorId")]
    public ulong ConnectorId { get; set; }

    /// <summary>
    /// Valid values in <see cref="AvailabilityType"/>
    /// </summary>
    [JsonProperty("type")]
    public AvailabilityType.Enum Type { get; set; }
}
