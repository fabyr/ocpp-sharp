using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetMonitoringBase", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetMonitoringBaseRequest : RequestPayload
{
    [JsonProperty("monitoringBase")]
    public MonitoringBaseType.Enum MonitoringBase { get; set; }
}
