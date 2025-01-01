using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetLocalListVersion", OcppMessageAttribute.Direction.PointToCentral)]
public class GetLocalListVersionResponse : ResponsePayload
{
    [JsonProperty("versionNumber")]
    public int VersionNumber { get; set; }
}
