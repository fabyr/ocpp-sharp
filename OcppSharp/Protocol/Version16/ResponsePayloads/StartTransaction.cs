using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "StartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class StartTransactionResponse : ResponsePayload
{
    [JsonPropertyName("idTagInfo")]
    public IdTagInfo IdTagInfo { get; set; } = IdTagInfo.Empty;

    [JsonPropertyName("transactionId")]
    public long TransactionId { get; set; }
}
