using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearVariableMonitoring", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearVariableMonitoringRequest : RequestPayload
{
    [JsonProperty("id")]
    public long[] Id { get; set; } = [];
}
