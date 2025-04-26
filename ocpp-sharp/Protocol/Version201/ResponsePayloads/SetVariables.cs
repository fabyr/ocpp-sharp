using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetVariables", OcppMessageAttribute.Direction.PointToCentral)]
public class SetVariablesResponse : ResponsePayload
{
    /// <summary>
    /// Must contain atleast one element.
    /// </summary>
    [JsonPropertyName("setVariableResult")]
    public SetVariableResult[] SetVariableResult { get; set; } = [];
}
