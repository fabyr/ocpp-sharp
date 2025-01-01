using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "PublishFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class PublishFirmwareResponse : ResponsePayload
{
    [JsonProperty("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonProperty("status")]
    public StatusInfo? StatusInfo { get; set; }
}
