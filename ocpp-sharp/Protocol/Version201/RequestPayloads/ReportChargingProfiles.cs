using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ReportChargingProfiles", OcppMessageAttribute.Direction.PointToCentral)]
public class ReportChargingProfilesRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("chargingLimitSource")]
    public ChargingLimitSourceType.Enum ChargingLimitSource { get; set; }

    [JsonPropertyName("tbc")]
    public bool? Tbc { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    /// <summary>
    /// Must contain atleast one element
    /// </summary>
    [JsonPropertyName("chargingProfile")]
    public ChargingProfile[] ChargingProfile { get; set; } = [];
}
