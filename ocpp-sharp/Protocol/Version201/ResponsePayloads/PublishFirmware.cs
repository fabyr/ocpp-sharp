using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "PublishFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class PublishFirmwareResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonPropertyName("status")]
    public StatusInfo? StatusInfo { get; set; }
}
