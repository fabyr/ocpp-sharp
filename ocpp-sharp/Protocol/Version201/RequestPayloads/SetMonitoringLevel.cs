using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetMonitoringLevel", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetMonitoringLevelRequest : RequestPayload
{
    public enum SeverityLevel : int
    {
        Danger = 0,
        HardwareFailure = 1,
        SystemFailure = 2,
        Critical = 3,
        Error = 4,
        Alert = 5,
        Warning = 6,
        Notice = 7,
        Informational = 8,
        Debug = 9
    }

    [JsonProperty("monitoringBase")]
    public SeverityLevel MonitoringBase { get; set; }
}
