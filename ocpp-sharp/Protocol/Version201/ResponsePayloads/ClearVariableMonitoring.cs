using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearVariableMonitoring", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearVariableMonitoringResponse : ResponsePayload
{
    [JsonPropertyName("clearMonitoringResult")]
    public ClearMonitoringResult[] ClearMonitoringResult { get; set; } = [];
}
