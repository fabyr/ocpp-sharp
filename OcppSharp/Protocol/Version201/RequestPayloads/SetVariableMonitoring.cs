using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetVariableMonitoring", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetVariableMonitoringRequest : RequestPayload
{
    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonPropertyName("setMonitoringData")]
    public SetMonitoringData[] SetMonitoringData { get; set; } = [];
}
