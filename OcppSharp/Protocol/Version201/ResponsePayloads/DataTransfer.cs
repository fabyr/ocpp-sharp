using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public DataTransferStatusType.Enum Status { get; set; }

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
