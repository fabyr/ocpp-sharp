using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "UpdateFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class UpdateFirmwareResponse : ResponsePayload
{
    [JsonProperty("status")]
    public UpdateFirmwareStatusType.Enum Status { get; set; }

    [JsonProperty("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
