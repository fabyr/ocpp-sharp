using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetVariables", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetVariablesRequest : RequestPayload
{
    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonProperty("setVariableData")]
    public SetVariableData[] SetVariableData { get; set; } = [];
}
