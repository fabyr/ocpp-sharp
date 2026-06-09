using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "CustomerInformation", OcppMessageAttribute.Direction.PointToCentral)]
public class CustomerInformationResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public CustomerInformationStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
