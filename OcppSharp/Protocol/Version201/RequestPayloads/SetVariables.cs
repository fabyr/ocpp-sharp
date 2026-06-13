using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetVariables", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetVariablesRequest : RequestPayload
{
    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonPropertyName("setVariableData")]
    public SetVariableData[] SetVariableData { get; set; } = [];
}
