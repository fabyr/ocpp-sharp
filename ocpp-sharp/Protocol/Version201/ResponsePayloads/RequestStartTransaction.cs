using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "RequestStartTransaction", OcppMessageAttribute.Direction.PointToCentral)]
public class RequestStartTransactionResponse : ResponsePayload
{
    [JsonProperty("status")]
    public RequestStartStopStatusType.Enum Status { get; set; }

    [JsonProperty("transactionId")]
    public CiString? TransactionId { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
