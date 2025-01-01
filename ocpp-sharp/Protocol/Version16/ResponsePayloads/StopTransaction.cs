using OcppSharp.Protocol.Version16.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "StopTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class StopTransactionResponse : ResponsePayload
{
    [JsonProperty("idTagInfo")]
    public IdTagInfo? IdTagInfo { get; set; }
}
