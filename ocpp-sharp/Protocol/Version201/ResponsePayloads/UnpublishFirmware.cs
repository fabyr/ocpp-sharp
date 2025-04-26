using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "UnpublishFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class UnpublishFirmwareResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public UnpublishFirmwareStatusType.Enum Status { get; set; }
}
