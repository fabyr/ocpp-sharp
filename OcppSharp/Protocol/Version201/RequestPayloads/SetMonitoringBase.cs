using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetMonitoringBase", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetMonitoringBaseRequest : RequestPayload
{
    [JsonPropertyName("monitoringBase")]
    public MonitoringBaseType.Enum MonitoringBase { get; set; }
}
