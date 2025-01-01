using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ChangeConfiguration", OcppMessageAttribute.Direction.PointToCentral)]
public class ChangeConfigurationResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ConfigurationStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public ConfigurationStatus.Enum Status { get; set; }
}
