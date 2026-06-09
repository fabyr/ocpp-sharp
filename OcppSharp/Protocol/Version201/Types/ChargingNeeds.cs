using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingNeeds
{
    public static readonly ChargingNeeds Empty = new();

    [JsonPropertyName("requestedEnergyTransfer")]
    public EnergyTransferModeType.Enum RequestedEnergyTransfer { get; set; }

    [JsonPropertyName("departureTime")]
    public DateTime? DepartureTime { get; set; }

    [JsonPropertyName("acChargingParameters")]
    public ACChargingParameters? AcChargingParameters { get; set; }

    [JsonPropertyName("dcChargingParameters")]
    public DCChargingParameters? DcChargingParameters { get; set; }
}
