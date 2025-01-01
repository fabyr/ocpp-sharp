using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearVariableMonitoring", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearVariableMonitoringResponse : ResponsePayload
{
    [JsonProperty("clearMonitoringResult")]
    public ClearMonitoringResult[] ClearMonitoringResult { get; set; } = [];
}
