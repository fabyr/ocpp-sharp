using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "NotifyEVChargingNeeds", OcppMessageAttribute.Direction.CentralToPoint)]
public class NotifyEVChargingNeedsResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public NotifyEVChargingNeedsStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
