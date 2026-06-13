using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetVariables", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetVariablesRequest : RequestPayload
{
    [JsonPropertyName("getVariableData")]
    public GetVariableData[] GetVariableData { get; set; } = [];
}
