using System;
using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetMonitoringLevel", OcppMessageAttribute.Direction.PointToCentral)]
public class SetMonitoringLevelResponse : ResponsePayload
{
    [JsonPropertyName("status")]
    public GenericStatusType.Enum Status { get; set; }

    [JsonPropertyName("statusInfo")]
    public StatusInfo? StatusInfo { get; set; }
}
