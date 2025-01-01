using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ChangeAvailability", OcppMessageAttribute.Direction.CentralToPoint)]
public class ChangeAvailabilityRequest : RequestPayload
{
    [JsonProperty("operationalStatus")]
    public OperationalStatusType.Enum OperationalStatus { get; set; }

    [JsonProperty("evse")]
    public EVSE? Evse { get; set; }
}
