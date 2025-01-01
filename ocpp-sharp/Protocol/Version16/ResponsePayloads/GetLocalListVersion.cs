using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetLocalListVersion", OcppMessageAttribute.Direction.PointToCentral)]
public class GetLocalListVersionResponse : ResponsePayload
{
    [JsonProperty("listVersion")]
    public long ListVersion { get; set; }
}
