using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "UnpublishFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class UnpublishFirmwareResponse : ResponsePayload
{
    [JsonProperty("status")]
    public UnpublishFirmwareStatusType.Enum Status { get; set; }
}
