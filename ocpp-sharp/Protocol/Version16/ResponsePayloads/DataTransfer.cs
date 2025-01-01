using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

// Can be received by both
[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "DataTransfer", OcppMessageAttribute.Direction.PointToCentral)]
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
