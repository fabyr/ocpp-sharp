using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetLocalListVersion", OcppMessageAttribute.Direction.PointToCentral)]
public class GetLocalListVersionResponse : ResponsePayload
{
    [JsonPropertyName("listVersion")]
    public long ListVersion { get; set; }
}
