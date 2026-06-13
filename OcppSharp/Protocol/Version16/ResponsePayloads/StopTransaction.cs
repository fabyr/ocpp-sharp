using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "StopTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class StopTransactionResponse : ResponsePayload
{
    [JsonPropertyName("idTagInfo")]
    public IdTagInfo? IdTagInfo { get; set; }
}
