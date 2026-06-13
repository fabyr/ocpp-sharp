using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ChangeAvailability", OcppMessageAttribute.Direction.CentralToPoint)]
public class ChangeAvailabilityRequest : RequestPayload
{
    [JsonPropertyName("operationalStatus")]
    public OperationalStatusType.Enum OperationalStatus { get; set; }

    [JsonPropertyName("evse")]
    public EVSE? Evse { get; set; }
}
