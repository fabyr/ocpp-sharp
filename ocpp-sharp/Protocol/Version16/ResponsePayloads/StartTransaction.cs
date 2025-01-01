using OcppSharp.Protocol.Version16.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "StartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class StartTransactionResponse : ResponsePayload
{
    [JsonProperty("idTagInfo")]
    public IdTagInfo IdTagInfo { get; set; } = IdTagInfo.Empty;

    [JsonProperty("transactionId")]
    public long TransactionId { get; set; }
}
