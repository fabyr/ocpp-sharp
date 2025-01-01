using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "NotifyEVChargingNeeds", OcppMessageAttribute.Direction.CentralToPoint)]
public class NotifyEVChargingNeedsResponse : ResponsePayload
{
    [JsonProperty("status")]
    public NotifyEVChargingNeedsStatusType.Enum Status { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
