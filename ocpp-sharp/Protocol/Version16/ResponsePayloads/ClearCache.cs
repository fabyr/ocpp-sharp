using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "ClearCache", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearCacheResponse : ResponsePayload
{
    /// <summary>
    /// Valid values in <see cref="ClearCacheStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public ClearCacheStatus.Enum Status { get; set; }
}
