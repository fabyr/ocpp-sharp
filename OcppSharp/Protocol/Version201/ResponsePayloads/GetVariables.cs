using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetVariables", OcppMessageAttribute.Direction.PointToCentral)]
public class GetVariablesResponse : ResponsePayload
{
    [JsonPropertyName("getVariableResult")]
    public GetVariableResult[] GetVariableResult { get; set; } = [];
}
