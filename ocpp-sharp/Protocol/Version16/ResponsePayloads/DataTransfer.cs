using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.Bidirectional)]
public class DataTransferResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="DataTransferStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public DataTransferStatus.Enum Status { get; set; }

    [JsonProperty("data")]
    public string? Data { get; set; }
}
