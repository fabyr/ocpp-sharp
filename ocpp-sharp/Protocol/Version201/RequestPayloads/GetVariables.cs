using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetVariables", OcppMessageAttribute.Direction.CentralToPoint)]
public class GetVariablesRequest : RequestPayload
{
    [JsonProperty("getVariableData")]
    public GetVariableData[] GetVariableData { get; set; } = [];
}
