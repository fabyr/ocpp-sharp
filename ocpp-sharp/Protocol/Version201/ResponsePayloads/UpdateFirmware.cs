using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "UpdateFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class UpdateFirmwareResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public UpdateFirmwareStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
