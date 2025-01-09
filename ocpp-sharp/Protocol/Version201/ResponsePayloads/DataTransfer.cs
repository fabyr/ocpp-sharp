using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferResponse : ResponsePayload
{
    [JsonProperty("status")]
    public DataTransferStatusType.Enum Status { get; set; }

    [JsonProperty("data")]
    public object? Data { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
