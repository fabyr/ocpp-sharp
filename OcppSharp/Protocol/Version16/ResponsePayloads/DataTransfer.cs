using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="DataTransferStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public DataTransferStatus.Enum Status { get; set; }

    [JsonPropertyName("data")]
    public string? Data { get; set; }
}
