using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetVariableMonitoring", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetVariableMonitoringRequest : RequestPayload
{
    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonProperty("setMonitoringData")]
    public SetMonitoringData[] SetMonitoringData { get; set; } = [];
}
