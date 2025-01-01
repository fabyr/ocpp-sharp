using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ReportChargingProfiles", OcppMessageAttribute.Direction.PointToCentral)]
public class ReportChargingProfilesRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("chargingLimitSource")]
    public ChargingLimitSourceType.Enum ChargingLimitSource { get; set; }

    [JsonProperty("tbc")]
    public bool? Tbc { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    /// <summary>
    /// Must contain atleast one element
    /// </summary>
    [JsonProperty("chargingProfile")]
    public ChargingProfile[] ChargingProfile { get; set; } = [];
}
