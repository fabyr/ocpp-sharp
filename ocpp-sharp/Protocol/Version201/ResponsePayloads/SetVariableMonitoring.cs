using Newtonsoft.Json;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetVariableMonitoring", OcppMessageAttribute.Direction.PointToCentral)]
public class SetVariableMonitoringResponse : ResponsePayload
{
    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonProperty("setMonitoringResult")]
    public SetMonitoringResult[] SetMonitoringResult { get; set; } = [];
}
