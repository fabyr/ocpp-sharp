using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearVariableMonitoring", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearVariableMonitoringRequest : RequestPayload
{
    [JsonPropertyName("id")]
    public long[] Id { get; set; } = [];
}
