using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Reset", OcppMessageAttribute.Direction.CentralToPoint)]
public class ResetRequest : RequestPayload
{
    [JsonProperty("type")]
    public ResetType.Enum Type { get; set; }

    [JsonProperty("type")]
    public long? EvseId { get; set; }
}
