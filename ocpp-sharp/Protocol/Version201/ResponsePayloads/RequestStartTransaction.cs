using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "RequestStartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class RequestStartTransactionResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public RequestStartStopStatusType.Enum Status { get; set; }

    [JsonPropertyName("transactionId")]
    public CiString? TransactionId { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
