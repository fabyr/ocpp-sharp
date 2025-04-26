using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetDiagnostics", OcppMessageAttribute.Direction.PointToCentral)]
public class GetDiagnosticsResponse : ResponsePayload
{
    [JsonPropertyName("fileName")]
    public CiString? FileName { get; set; }
}
