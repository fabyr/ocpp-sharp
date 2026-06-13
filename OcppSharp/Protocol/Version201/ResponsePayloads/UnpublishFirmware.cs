using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "UnpublishFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class UnpublishFirmwareResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public UnpublishFirmwareStatusType.Enum Status { get; set; }
}
