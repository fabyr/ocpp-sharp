using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearDisplayMessage", OcppMessageAttribute.Direction.PointToCentral)]
public class ClearDisplayMessageResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public ClearMessageStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
